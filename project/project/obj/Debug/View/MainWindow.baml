   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject  5   	       project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:project     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MainWindow��5   	   $��534.333��6   $��811.667��6-      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��0 40 0 0q�6   $��3��6&   $��Center=�6:   $��20(�6W   $
��Bold"�6e   .��6w   Our6|   �� 5      ���#D50000$��0 40 0 0q�6)   $��3��6;   $��Center=�6O   $��20(�6l   $
��Bold"�6z   .��6�   
"Strong"6�   �� 5       $��0 40 0 0q�6   $��3��6&   $��Center=�6:   $��20(�6W   $
��Bold"�6e   .��6w   Organization6�   5!      #  MaterialDesignThemes.Wpf.Card  5#   
   $��
10,10,10,0q�6   $��0��62   $��1��6C   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6Q      ShadowEdges$ Bottom,Right=�6�   $	��286��6�   .��5$      �� .+�5%      �� $	��144��6   $	��300��6%   $
��Fill=�61   $��../images/coders.jpg��6@   6`   �� 5&      $��
Programmer��6    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6_   $��Right=�6�   $��
0 -20 10 0q�6�   ��67   �� *OpenConcreteCommand+.��5'      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$	 Eye=�6.   5(      �� 5)      	 �� Padding$	 
10 0 10 10q�6   $��
10 0 10 10q�61   $
��Bold"�6E    % !MaterialDesignSubheadingTextBlock#��[ 6W   Программисты6�   �� 5*      $	 	10 0 10 0q�6   $
��Wrap=�61   $��
10 0 10 30q�6E   wuСамые ленивые, но самые трудоспособные люди на земле. Ненавидят �� 6�   $
��Bold"�6�   дизайнеров6�   .6�   5,      5-        5.   
   $��10q�6   $��1��6*   $��1��6:   $ Depth3=�6H   $ Bottom,Right=�6y   .��5/      �� .+�50      �� $��../images/designers.jpg��6   $	��144��69   6H   �� 51      $��Designer��6   #��[ 6]   $��Right=�6�   $��
0 -20 10 0q�6�   ��65   �� *OpenConcreteCommand+.��52        $	 Eye=�6.   53      �� 54      $	 
10 0 10 10q�6   $��
10 0 10 10q�61   $
��Bold"�6E   #��[ 6W   Дизайнеры6�   �� 55      $	 
10 0 10 10q�6   $
��Wrap=�61   $��
10 0 10 10q�6E   ��Терпеть не могут градиенты и тени, но сами их постоянно используют. Ненавидят �� 6�   $
��Bold"�6�   программистов6�   .6�   56      57        58   
   $��
10,10,10,0q�6   $��2��62   $��1��6B   $ Depth3=�6P   $ Bottom,Right=�6�   $	��285��6�   .��59      �� $	��281��6   .+�5:      �� $
��Fill=�6   $��../images/sys.jpg��6'   $	��144��6B   $��0 0 0 0q�6O   �� 5;      $��System administrator��6   #��[ 6i   $��Right=�6�   $��
0 -20 10 0q�6�   ��6A   �� *OpenConcreteCommand+.��5<        $	 Eye=�6.   5=      �� 5>      $	 
10 0 10 10q�6   $��
10 0 10 10q�61   $
��Bold"�6E   #��[ 6W   �� 6�   $�Сисадмины��6�   6�   �� 5?      $	 
10 0 10 10q�6   $
��Wrap=�61   $��
10 0 10 10q�6E   �� 6Z   $p�jВечно заспаные, вечно в свитере, вечно с бубном. Ненавидят ��6^   �� 6�   .F�5@      �� $
��Bold"�6$   �� 67   $�бухгалтеров��6;   6Q   5A      6+   5B      5C      �� 5D   
   -   5        
 ��Name$
 logBtn��5E      $��1��5D      $��2��6!    " MaterialDesignRaisedDarkButton#��[ 5F      $	��200��5G      $��View salary report��5I      ��5H      �� *ViewSalaryReportCommand+5J      5L      5M      