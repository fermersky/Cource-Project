   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject      project.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:project     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  
MainWindow��$	��523��$	��811��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .���  � RowDefinitions �� $	��120 ��� $
��auto ��� $��40 � � ColumnDefinitions �� �� �� .+��� $��0 40 0 0q�$��3��$��Center=�$��20(�$
��Bold"�.��Our "Strong" Organization#  MaterialDesignThemes.Wpf.Card  $��10q�$��0��$��1��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�   ShadowEdges$ Bottom,Right=�.���� .+��� $��../images/coders.jpg���� $��
Programmer�� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ $��Right=�$��
0 -20 10 0q����� *OpenConcreteCommand+.��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Eye=��� $��
10 0 10 10q�$
��Bold"� % !MaterialDesignSubheadingTextBlock#��[ Программисты�� $
��Wrap=�$��
10 0 10 10q�wuСамые ленивые, но самые трудоспособные люди на земле. Ненавидят �� $
��Bold"�дизайнеров.  $��10q�$��1��$��1��$ Depth3=�$ Bottom,Right=�.���� .+��� $��../images/designers.jpg���� $��Designer��#��[ $��Right=�$��
0 -20 10 0q����� *OpenConcreteCommand+.��  $	 Eye=��� $��
10 0 10 10q�$
��Bold"�#��[ Дизайнеры�� $
��Wrap=�$��
10 0 10 10q���Терпеть не могут градиенты и тени, но сами их постоянно используют. Ненавидят �� $
��Bold"�программистов.  $��10q�$��2��$��1��$ Depth3=�$ Bottom,Right=�.���� .+��� $��../images/sys.jpg���� $��System administrator��#��[ $��Right=�$��
0 -20 10 0q����� *OpenConcreteCommand+.��  $	 Eye=��� $��
10 0 10 10q�$
��Bold"�#��[ Сисадмины�� $
��Wrap=�$��
10 0 10 10q�ljВечно заспаные, вечно в свитере, вечно с бубном. Ненавидят �� $
��Bold"�бухгалтеров�� -    ��Name$ logBtn��$��1��$��2�� " MaterialDesignRaisedDarkButton#��[ $	��200��$��View salary report������ *ViewSalaryReportCommand+