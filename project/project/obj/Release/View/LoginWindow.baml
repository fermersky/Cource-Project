   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject      project.LoginWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:project     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���   � Title$ LoginWindow��$	��450��$	��800��.���  � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��0.2* ��� �� $
��0.2* �.+��� $��1��$��1��.+��� -    ��Name$ serverTb��$
��Bold"�
���   �$��17(�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Server name�� % !MaterialDesignFloatingHintTextBox#��[ $��0 0 0 20q����� *
ServerName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $ 
databaseTb��$
��Bold"�
���   �$��17(�$ Database name��#��[ $��0 0 0 20q����� *DatabseName+$ TwoWay=�$ PropertyChanged=��� -   $ loginTb��$
��Bold"�
���   �$��17(�$ Login��#��[ $��0 0 0 20q����� *Login+$ TwoWay=�$ PropertyChanged=�G� -   	 G�Name$	 passTb��$
��Bold"�
���   �$��17(�$ Password�� ) %MaterialDesignFloatingHintPasswordBox#��[ $��0 0 0 20q��� -   
 ��Name$
 logBtn�� $  MaterialDesignRaisedAccentButton#��[ $	��100��$��Log in�� � ToolTip$ Authorize me������ *LoginCommand+����  �� ElementName$ passTb���� -    ��Name$ lb���� -    ��Name$ errorTb�� �� Padding$ 0 8 0 0q�$��0 60 0 0q�$��30�����#F5D0D5���#671322$
��Bold"� �� TextAlignment$ Center=�$��1��$��2��
An error