using AutoQuest.Engine;

using Spectre.Console;

namespace  AutoQuest.Terminal;

public static class Program
{
    public static void Main(string[] args)
    {
        // load
        AnsiConsole.MarkupLine("[yellow italic]Reluctantly waking up...[/]");
        var engine = new GameEngine();

        // add the player panel
        // var playerStats = new Table().RoundedBorder()
        //     .BorderColor(Color.White)
        //     //.Expand()
        //     .Title("Player Stats")
        //     .HideHeaders();
        var playerStats = new Grid();
        playerStats.AddColumns(2);
        //playerStats.AddColumn(string.Empty, c => c.Width(18));
        //playerStats.AddColumn(string.Empty);

        var player = engine.Player;
        playerStats.AddRow("Name:", $"[cyan bold]{player.Name}[/]");
        playerStats.AddRow("Health:", $"[green bold]{player.Health}[/]");
        playerStats.AddRow("Exp.:", $"[blue bold]{player.Experience}[/]");

        var playerPnl = new Panel(playerStats).Header("Player").RoundedBorder();
        
        // add the activity panel
        var activity = new Table().Border(TableBorder.None) //.RoundedBorder()
            //.BorderColor(Color.Gray);
            .Expand();
                                        //.Title("Activity");
        activity.AddColumn("Time", c => c.Width(12));
        activity.AddColumn("Message");
        activity.AddRow(new Rule(), new Rule());
        var actHeader = new Panel(activity).Header("Activity")
                                                 .BorderColor(Color.Gray)
                                                 .RoundedBorder()
                                                 .Expand();
        
        // create the overall layout
        var title = new FigletText(FigletFont.Default, "AutoQuest!");
        title.Justification = Justify.Center;
        
        // TODO: convert to a Grid()?
        var desktop = new Table().RoundedBorder()
            .BorderColor(Color.Gray)
            .Expand()
            .HideHeaders();
        desktop.AddColumn("");

        // add the sub-panels details
        desktop.AddRow(title);
        desktop.AddRow(playerPnl);
        //desktop.AddRow(activity);
        desktop.AddRow(actHeader);
        
        // setup live updating
        AnsiConsole.Live(desktop)
            .Start(ctx =>
            {
                
                // temporary hook to get output from the engine...
                void Log(string message)
                {
            
                    //playerStats.UpdateCell(0, 1, $"[cyan bold]{player.Name}[/]");
                    //playerStats.UpdateCell(1, 1, $"[green bold]{player.Health}[/]");
                    //playerStats.UpdateCell(2, 1, $"[blue bold]{player.Experience}[/]");
            
                    // only display the last 5 entries of activity
                    activity.InsertRow(1, $"{DateTime.Now:HH:mm:ss.fff}", message);
                    if (activity.Rows.Count > 6)
                    {
                        activity.Rows.RemoveAt(activity.Rows.Count  - 1);
                    }
            
                    // re-render the display
                    Thread.Sleep(200);
                    ctx.Refresh();
                }
        
                // kick the engine...
                engine.Initialize(Log);
        
                // render the display
                ctx.Refresh();
        
                do
                {
                    engine.DoTick(Log);
                } while (engine.Player.State != PlayerState.Dead 
                         && engine.Location < engine.Destination);

                Log(string.Empty);
                //var player = engine.Player;
                string stateColor = player.State == PlayerState.Alive ? "green" : "red";
                Log($"[gray]Player [/][cyan bold]{player.Name}[/][gray] is [/][{stateColor}]{player.State}[/][gray]![/]");
                Log($"[gray]Travelled: [/][yellow bold]{engine.Location}[/][gray] KMs and got [/][blue bold]{player.Experience}[/][gray] xp![/]");
        
                // complete!
                //Log("[white bold underline]Complete.[/]");
            
                // only display the last 5 entries of activity
                if (activity.Rows.Count > 5)
                {
                    activity.Rows.RemoveAt(activity.Rows.Count  - 1);
                }
            
                // re-render the display
                ctx.Refresh();
            });
    }
}

