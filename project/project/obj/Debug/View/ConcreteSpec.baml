   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5	   	   1clr-namespace:project.Helpersproject.Helpers  5
   	       project.ConcreteSpec   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:project     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5	   	   *local1clr-namespace:project.Helpers  5
   	   $	��600��5   .   $��1236.675��6;     � Title  6	   �� *_currentSpeciality+ � 	Resources 5      (  "project.Helpers.ImgSourceConverter   ImgSourceConverter��%   &	          5   
   6A   5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $	��300 �6   6-    � RowDefinitions 5   
   �� 5      6   �� 5      $	��140 �6   6+   .+�5   
   �� $��1��6    �� Orientation$ Vertical=�6%   .+�5      �� $��0 30 0 0q�6   $ 
Horizontal=�6,   $
��Left=�6E   $	��Top=�6`   .+�5      �� $��16(�6   $��	20 0 10 0q�6*   $��Center=�6=   	Search:6a   �� 5      -   5         ��Name$ tbSearch��5      $��Center=�5        �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5"      $	��150��5#      $��30��5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ here...��5%      $��	20 0 10 0q�5&      $��16(�5'      ��5      �� *SearchPattern+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.��5(      .  (System.Windows.Interactivity.Interaction   Triggers 5)      /  )System.Windows.Interactivity.EventTrigger  5*         	EventName$ TextChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5+      6  0System.Windows.Interactivity.InvokeCommandAction     Command 5,      �� *FilterWorkersCommand+   CommandParameter 5-      ��  �� ElementName$ tbSearch�� �� Path$
 Text�5.      .��5/   .   50      51      �� 52      $��	20 40 0 0q�6   $��1��6,   .+�53      �� $ 
Horizontal=�6   $��	0 10 0 10q�67   .+�54      �� $��16(�6    $��0 0 10 0q�6.   
Surname:6J   d� 55       ( $MaterialDesignSwitchDarkToggleButton#��[ 56       � ToolTip$* $MaterialDesignSwitchDarkToggleButton��57       d� 	IsChecked 58      �� *FilterBySurnameOn+$	 TwoWay=�$
 PropertyChanged=�59      �� 5:      $ 
Horizontal=�6   $��0 5 0 10q�66   .+�5;      �� $��16(�6    $��0 0 10 0q�6.   
Firstname:6L   d� 5<      #��[ 5=      $* $MaterialDesignSwitchDarkToggleButton��5>       5?      �� *FilterByFirstnameOn+$	 TwoWay=�$
 PropertyChanged=�5@      �� 5A      $ 
Horizontal=�6   $��0 5 0 10q�66   .+�5B      �� $��16(�6    $��0 0 10 0q�6.   	Lastname:6K   d� 5C      #��[ 5D      $* $MaterialDesignSwitchDarkToggleButton��5E       5F      �� *FilterByLastnameOn+$	 TwoWay=�$
 PropertyChanged=�5G      �� 5H      $ 
Horizontal=�6   $��0 5 0 10q�66   .+�5I      �� $��16(�6    $��0 0 10 0q�6.   Age:6F   d� 5J      #��[ 5K      $* $MaterialDesignSwitchDarkToggleButton��5L       5M      �� *FilterByAgeOn+$	 TwoWay=�$
 PropertyChanged=�5N      �� 5O      $ 
Horizontal=�6   $��0 5 0 10q�66   .+�5P      �� $��16(�6    $��0 0 10 0q�6.   	Gender:6I   	� 5Q      $��0 0 20 0q�6y   $��16(�6�    6"   �� *FilterMaleOn+$	 TwoWay=�$
 PropertyChanged=�.��6�   Male6�   	� 5R      $��16(�6{    6"   �� *FilterFemaleOn+$	 TwoWay=�$
 PropertyChanged=�.��6�   Female6�   5S      5U      5W      �� 5X   
   -   5         ��Name$ WorkersListView��5X   �   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� SelectedIndex 6   �� $ SelectedIndexValue� �� SelectedItem 6F   �� *SelectedWorker+$
 PropertyChanged=�$	 TwoWay=���6�   �� *	Workers+$
 PropertyChanged=�$	 TwoWay=���5Y      �� 5Z      .R�5[      � .+�5\      #  MaterialDesignThemes.Wpf.Card  $	��200��6.   .��5]      �  5^   "   �� 5_   &   $	��140 �64   �� 5`   &   $��* �64   �� 5a   &   $
��Auto �64   .+�5c   "   �� $	��180��5e   #   $	��200��5f   #   $��Stretch=�5g   #   $	��Top=�6A   $��UniformToFill=�5h   #   ��5d   #   �� *	ImgFile+ �� 	Converter# [  $	 OneWay=�5h   #   �� 5i   "   $��0��5j   #    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5k   #   $��Right=�5l   #   $��Bottom=�5m   #   $# Double Click to see full info��5n   #   $��
0 0 16 -20q�5o   #   .��5p   #   '  !MaterialDesignThemes.Wpf.PackIcon  �	  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]] 	  Kind$ Account=�6;   5q   #   �� 5r   "   $��1��6-   $��8 24 8 0q�6:   .+�5s   &   �� $ Vertical=�61   .+�5t   *   �� $��14(�65   $��0 0 5 0q�6C   $
��Bold"�6T   ��6f   �� *	Surname+6�   �� 5u   *   $ 
Horizontal=�65   .+�5v   .   �� $��14(�69   $��0 0 5 0q�6G   $
��Bold"�6X   ��6j   �� *	Firstname+6�   �� 5w   .   $��14(�68   $��0 0 5 10q�6F   $
��Bold"�6X   ��6j   �� *
Lastname+6�   5x   +   5y   '   �� 5z   &   $ Vertical=�61   .+�5{   *   �� $ 
Horizontal=�65   .+�5|   .     $ Phone=�6F   �� 5}   .   $��5 0 5 0q�68   $
��Bold"�6I   ��6[   �� *Phone+ �� StringFormat$ +380{0}��6�   5~   +   �� 5   *   $ 
Horizontal=�65   .+�5�   .     $ Money=�6F   �� 5�   .   $��5 0 5 0q�68   $
��Bold"�6I   ��6[   �� *Salary+6u   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .     $ UserAddress=�6F   �� 5�   .   $��5 0 5 0q�68   $
��Bold"�6I   ��6[   �� *	Address+6v   5�   +   5�   '   5�   #   �� 5�   "   $��Right=�5�   %   $��2��5�   %   $ 
Horizontal=�5�   %   $��8q�5�   %   .+�5�   &   ��  ��Name$ EditBtn��5�   )   -   5          MaterialDesignToolButton#��[ 5�   )   $��30��5�   )   $��2 0 2 0q�5�   )   +
  %MaterialDesignThemes.Wpf.RippleAssist 
  
IsCentered . 
 � Tag 5�   )   ��  �� RelativeSource ��  �� AncestorType" ��.��5�   *     $ Pencil=�6B   5�   '   5�   #   5�      5�      5�      5�      ��5�      �� 5�      .R�5�      �   � Orientation$  
Horizontal=�6    $	��Top=�69   $��Disabled=�5�       ��5�   Q   ��  �� ! �� Mode$! FindAncestor=�$ ListViewL�$ ActualWidth�5�   X   5�       5�        5�      $ MouseDoubleClick��6!   . 5�         5�      �� *ViewWorkerInfoCommand+ 5�      �� $ WorkersListView��$ SelectedItem�5�      5�      �� 5�   
   $��1��5�      $��Right=�5�      $��	0 0 30 30q�5�       , (MaterialDesignFloatingActionAccentButton#��[ 5�      $ Add new Worker��5�      ��5�      �� *AddWorkerCommand+.��5�        $	 Add=�6&   $��24��61   $��24��6=   5�      '  !MaterialDesignThemes.Wpf.Snackbar  5�   
   -   5        "  Name$" SnackbarFive��5�   r   $��1��6"   $��Stretch=�6T   #   IsActive# 6/   �� *TooltipIsActive+$   Message.$ 5�      .  (MaterialDesignThemes.Wpf.SnackbarMessage  %   ActionContent$% OK��5�      ��5�      �� *TooltipText+5�      5�      5�       5�        5�   
   $ 	Activated��6   . 5�         6$   �� *FilterWorkersCommand+5�      5�      