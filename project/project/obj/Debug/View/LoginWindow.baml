   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject  5   	       project.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:project     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � Title$ LoginWindow��5   	   $	��450��6   $	��800��6*   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.2* �6   6,   �� 5      6   �� 5      $
��0.2* �6   6,   .+�5    
   �� $��1��6   $��1��6%   .+�5"      �� -   5         ��Name$ serverTb��5"   d   $
��Bold"�6v   
���   �$��17(�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Server name��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��0 0 0 20q�6  ��6   �� *
ServerName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5#      -   5        $ 
databaseTb��5#   e   $
��Bold"�6y   
���   �$��17(�6�   $ Database name��6�   #��[ 6�   $��0 0 0 20q�6  ��6   �� *DatabseName+$ TwoWay=�$ PropertyChanged=�6  �� 5$      -   5        $ loginTb��5$   _   $
��Bold"�6p   
���   �$��17(�6�   $ Login��6�   #��[ 6�   $��0 0 0 20q�6  ��6   �� *Login+$ TwoWay=�$ PropertyChanged=�6  G� 5%      -   5        	 G�Name$	 passTb��5%      $
��Bold"�6*   
���   �$��17(�6O   $ Password��5&       ) %MaterialDesignFloatingHintPasswordBox#��[ 5'      $��0 0 0 20q�6O   �� 5(      -   5        
 ��Name$
 logBtn��5)       $  MaterialDesignRaisedAccentButton#��[ 5,      $	��100��5-      $��Log in��5.       � ToolTip$ Authorize me��5/      ��5*      �� *LoginCommand+��5+      ��  �� ElementName$ passTb��50      �� 51      -   5         ��Name$ lb��51      6"   52      �� 53   
   -   5         ��Name$ errorTb��53   &    �� Padding$ 0 8 0 0q�6   $��0 60 0 0q�67   $��30��6I   ���#F5D0D5���#671322$
��Bold"�6    �� TextAlignment$ Center=�6�   $��1��6�   $��2��6�   
An error6�   54      56      