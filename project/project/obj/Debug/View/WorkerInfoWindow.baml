   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:project.Viewproject.View  5   	   1clr-namespace:project.Helpersproject.Helpers  5   	   #    project.View.WorkerInfoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:project.View     5   	   0local1clr-namespace:project.Helpers     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  Window��5
   	   $��483.215��5   &   $��802.031��67    � Title 6	   �� *
Speciality+ � 	Resources 5      (  "project.Helpers.ImgSourceConverter   ImgSourceConverter��%   &	          5   
   6A   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      $��10 �6   6*   .+�5   
   �� -   5         ��Name$ Image��5      $	��Top=�6   $��
20 20 0 20q�67   $	��300��6K   ��6\   �� *	ImgFile+ �� 	Converter# [  6�   �� 5   
   $��20 0 0 0q�6   $��1��6'   .+�5      �� $��0 10 0 0q�6   $��1��6+    �� Orientation$ 
Horizontal=�6;    � DataContext 6T   �� *CurrentWorker+.+�5      �� ���#00796B$��20(�6-   $
��Bold"�6;   ��6M   �� *	Surname+6k   �� 5      $��20(�6   ��6&   �� *	Firstname+6F   �� 5      $��20(�6   ��6&   �� *
Lastname+6E   5      �� 5       $��0 10 0 0q�6   $��1��6+   $ Vertical=�6;    6R   �� *CurrentWorker+.+�5!      �� $ 
Horizontal=�6   .+�5"      �� $��19(�6   ���#FF3D00.��6?   |6B   �� 5#      ���#1C1C1C$��18(�61   .��6?   Speciality:6L   �� 5$      $��Italic$�6   $��18(�6/   ��6=   �� *Specialties.SpecName+6h   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��19(�6   ���#FF3D00.��6?   |6B   �� 5(      ���#1C1C1C$��18(�61   .��6?   
Address:6I   �� 5)      $��Italic$�6   $��18(�6/   ��6=   �� *	Address+6[   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $��19(�6   ���#FF3D00.��6?   |6B   �� 5-      ���#1C1C1C$��18(�61   .��6?   Phone:6G   �� 5.      $��Italic$�6   $��18(�6/   ��6=   �� *Phone+	 �� StringFormat$	 +380{0}��6o   5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��19(�6   ���#FF3D00.��6?   |6B   �� 52      ���#1C1C1C$��18(�61   .��6?   
Birthdate:6K   �� 53      $��Italic$�6   $��18(�6/   ��6=   �� *	BirthDate+6]   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��19(�6   ���#FF3D00.��6?   |6B   �� 57      ���#1C1C1C$��18(�61   .��6?   	Salary:6H   �� 58      $��Italic$�6   $��18(�6/   ��6=   �� *Salary+$
	 {0}$��6o   59      5;      �� 5<      $ 
Horizontal=�6   .+�5=      '  !MaterialDesignThemes.Wpf.PackIcon  $��20��6*   $��20��65   $��0 17 0 0q�6A   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 HamburgerMenu=�6S   �� 5>      $��0 10 0 0q�6   $��18(�6*   .��68   Certificates6F   5?      �� 5A      $��1��6   $��0 0 0 20q�6#   ��65   �� *Certificates+��5B      �� 5C      .R�5D      �� $��0 0 0 10q�6%   $ 
Horizontal=�67   .+�5E      �� $��0 0 10 0q�6(   $��Italic$�6:   $��18(�6M   ��6[   ��  �� Path$ Certificates.CompanyName��� 5F      $��18(�6(   $
��Bold"�66   ��6H   �� $ Certificates.Description�5G      5H      5J      5K      �� 5M   
   -   5        $��30q�5N      $��1��5O      $��Bottom=�5P      $��Right=�5R       & "MaterialDesignFloatingActionButton#��[ 5S       � ToolTip$ Back to Workers��5T      .��5U        $
 	ArrowLeft=�6&   $��24��67   $��24��6C   5V      �� 5W   
   $��2��6   $��1��6%   64   5X      5Y      