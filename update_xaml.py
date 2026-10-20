import re

with open('/Users/wagnercruz/workspace/Resonalyze.Next/source/Resonalyze.UI/Views/MainWindow.axaml', 'r') as f:
    content = f.read()

# Replace the Center Panel mock text with the actual PlotView
content = re.sub(
    r'<TextBlock Text="GRÁFICO:".*?Margin="0,20,0,0"\/>\n\s*<\/StackPanel>',
    '<oxy:PlotView Model="{Binding PlotModel}" Background="Transparent" />',
    content,
    flags=re.DOTALL
)

with open('/Users/wagnercruz/workspace/Resonalyze.Next/source/Resonalyze.UI/Views/MainWindow.axaml', 'w') as f:
    f.write(content)
