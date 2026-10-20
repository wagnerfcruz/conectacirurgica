using CommunityToolkit.Mvvm.ComponentModel;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using System;

namespace Resonalyze.UI.ViewModels;

public enum AppMode
{
    FrequencyResponse,
    Phase,
    GroupDelay,
    Impulse,
    Waterfall,
    TimeAlignment
}

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private AppMode _currentMode = AppMode.FrequencyResponse;

    [ObservableProperty]
    private bool _isAutomotiveMode = false;

    [ObservableProperty]
    private PlotModel _plotModel;

    public MainViewModel()
    {
        InitializePlot();
    }

    private void InitializePlot()
    {
        PlotModel = new PlotModel 
        { 
            Title = "Frequency Response (Mock)",
            TextColor = OxyColors.White,
            PlotAreaBorderColor = OxyColors.Gray
        };

        PlotModel.Axes.Add(new LogarithmicAxis 
        { 
            Position = AxisPosition.Bottom, 
            Title = "Frequência (Hz)",
            MajorGridlineStyle = LineStyle.Solid,
            MinorGridlineStyle = LineStyle.Dot,
            MajorGridlineColor = OxyColor.Parse("#333333"),
            TicklineColor = OxyColors.White,
            Minimum = 20,
            Maximum = 20000
        });

        PlotModel.Axes.Add(new LinearAxis 
        { 
            Position = AxisPosition.Left, 
            Title = "SPL (dB)",
            MajorGridlineStyle = LineStyle.Solid,
            MajorGridlineColor = OxyColor.Parse("#333333"),
            TicklineColor = OxyColors.White
        });

        var series = new LineSeries { Title = "Midbass Esquerdo", Color = OxyColors.Cyan, StrokeThickness = 2 };
        for (int i = 20; i <= 20000; i += 50)
        {
            series.Points.Add(new DataPoint(i, 80 + Math.Sin(i / 100.0) * 5 + Math.Log10(i) * 2));
        }
        PlotModel.Series.Add(series);
    }

    partial void OnCurrentModeChanged(AppMode value)
    {
        PlotModel.Title = $"{value} (Mock)";
        PlotModel.InvalidatePlot(true);
    }
}
