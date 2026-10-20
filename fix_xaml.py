import re

with open('/Users/wagnercruz/workspace/Resonalyze.Next/source/Resonalyze.UI/Views/MainWindow.axaml', 'r') as f:
    content = f.read()

# Fix the broken StackPanel in the center area from the previous run
content = re.sub(
    r'<StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">\n\s*<oxy:PlotView Model="\{Binding PlotModel\}" Background="Transparent" \/>\n\s*<\/Border>',
    '<oxy:PlotView Model="{Binding PlotModel}" Background="Transparent" />\n            </Border>',
    content,
    flags=re.DOTALL
)

with open('/Users/wagnercruz/workspace/Resonalyze.Next/source/Resonalyze.UI/Views/MainWindow.axaml', 'w') as f:
    f.write(content)
