   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:project.Viewproject.View  5   	   "    project.View.LoginUserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:project.View     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � Title$ LoginWindow��5   	   $��490.5��6   $��795.5��6,    � Icon$, &/project;component/images/bglogin2.jpg��6:   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      $
��0.1* �6   6,   .+�5   
   �� $	��Top=�6   $��1��6-   $��0��6=   .+�5       �� $��	0,40,10,0q�6   $��../images/secur.png��6'   $	��185��6D   6S   �� 5!      -   5         ��Name$ loginTb��5!   _   $
��Bold"�6p   
���   �$��17(�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Login��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��	0 -0 0 20q�6  ��6   �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=�6  G� 5"      -   5        
 G�Name$
 passTb��5"      $
��Bold"�6*   
���   �$��17(�6O   $ Password��5#       ) %MaterialDesignFloatingHintPasswordBox#��[ 5$      $��0 0 0 20q�6O   �� 5%      -   5         ��Name$ logBtn��5&       " MaterialDesignRaisedDarkButton#��[ 5'      $	��100��5(      $��Log in��5)       � ToolTip$ Authorize me��5,      ��5*      �� *LoginCommand+��5+      ��  �� ElementName$ passTb��5-      �� 5.      -   5         ��Name$ lb��5.      6"   5/      �� 50   
   -   5         ��Name$ errorTb��50   &    �� Padding$ 0 8 0 0q�6   $��0 60 0 0q�67   $��30��6I   ���#F5D0D5���#671322$
��Bold"�6    �� TextAlignment$ Center=�6�   $��1��6�   $��2��6�   
An error6�   51      53      