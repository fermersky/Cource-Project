   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 1clr-namespace:project.Helpersproject.Helpers      project.ConcreteSpec   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:project     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  *local1clr-namespace:project.Helpers  $	��450��$	��800��  � Title  �� *_currentSpeciality+ � 	Resources (  "project.Helpers.ImgSourceConverter   ImgSourceConverter��%   &	          .���  � ColumnDefinitions �� �� $	��300 � � RowDefinitions �� .+��� $��1�� �� Orientation$ Vertical=�.+��� $��0 30 0 0q�$ 
Horizontal=�$
��Left=�$	��Top=�.+��� $��16(�$��	20 0 10 0q�$��Center=�	Search:�� -    ��Name$ tbSearch��$��Center=� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$	��150��$��30��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ here...��$��	20 0 10 0q�$��16(����� *SearchPattern+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ TextChanged��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *FilterWorkersCommand+   CommandParameter ��  �� ElementName$ tbSearch�� �� Path$
 Text�.���� $��	20 40 0 0q�$��1��.+��� $ 
Horizontal=�$��	0 10 0 10q�.+��� $��16(�$��0 0 10 0q�
Surname:d�  ( $MaterialDesignSwitchDarkToggleButton#��[  � ToolTip$* $MaterialDesignSwitchDarkToggleButton�� d� 	IsChecked �� *FilterBySurnameOn+$	 TwoWay=�$
 PropertyChanged=��� $ 
Horizontal=�$��0 5 0 10q�.+��� $��16(�$��0 0 10 0q�
Firstname:d� #��[ $* $MaterialDesignSwitchDarkToggleButton�� �� *FilterByFirstnameOn+$	 TwoWay=�$
 PropertyChanged=��� $ 
Horizontal=�$��0 5 0 10q�.+��� $��16(�$��0 0 10 0q�	Lastname:d� #��[ $* $MaterialDesignSwitchDarkToggleButton�� �� *FilterByLastnameOn+$	 TwoWay=�$
 PropertyChanged=��� $ 
Horizontal=�$��0 5 0 10q�.+��� $��16(�$��0 0 10 0q�Age:d� #��[ $* $MaterialDesignSwitchDarkToggleButton�� �� *FilterByAgeOn+$	 TwoWay=�$
 PropertyChanged=��� $ 
Horizontal=�$��0 5 0 10q�.+��� $��16(�$��0 0 10 0q�	Gender:	� $��0 0 20 0q�$��16(� �� *FilterMaleOn+$	 TwoWay=�$
 PropertyChanged=�.��Male	� $��16(� �� *FilterFemaleOn+$	 TwoWay=�$
 PropertyChanged=�.��Female�� -    ��Name$ WorkersListView��$ �� IsSynchronizedWithCurrentItem$
 TrueY����� *	Workers+$
 PropertyChanged=����� .R�� .+�#  MaterialDesignThemes.Wpf.Card  $	��200��.���  �� $	��140 ��� $��* ��� $
��Auto �.+��� $	��140��$	��200��$��UniformToFill=����� *	ImgFile+ �� 	Converter# [  �� $��0�� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ $��Right=�$��Bottom=�$��
0 0 16 -20q�.��'  !MaterialDesignThemes.Wpf.PackIcon  �	  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]] 	  Kind$	 Eye=��� $��1��$��8 24 8 0q�.+��� $ 
Horizontal=�.+��� $��14(�$��0 0 5 10q�$
��Bold"����� *	Surname+�� $��14(�$��0 0 5 10q�$
��Bold"����� *	Firstname+�� $��14(�$��0 0 5 10q�$
��Bold"����� *
Lastname+�� $ Vertical=�.+��� $ 
Horizontal=�.+�  $ Phone=��� $��5 0 5 0q�$
��Bold"����� *Phone+�� $ 
Horizontal=�.+�  $ Money=��� $��5 0 5 0q�$
��Bold"����� *Salary+�� $ 
Horizontal=�.+�  $ UserAddress=��� $��5 0 5 0q�$
��Bold"����� *	Address+�� $��Right=�$��2��$ 
Horizontal=�$��8q�.+���   MaterialDesignToolButton#��[ $��30��$��2 0 2 0q�+
  %MaterialDesignThemes.Wpf.RippleAssist 
  
IsCentered . .��  $ ShareVariant=��� #��[ $��30��$��2 0 2 0q� . .��  $ Heart=�'  !MaterialDesignThemes.Wpf.PopupBox  $��2 0 2 0q�   PopupContent. �� .+��� $
��More���� $��Options������ .R��  � Orientation$ 
Horizontal=�$	��Top=�