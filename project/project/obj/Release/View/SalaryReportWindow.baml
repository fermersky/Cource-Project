   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:project.Viewproject.View  %    project.View.SalaryReportWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:project.View       � Title$  SalaryReportWindow��$��538.013��$��805.678��.���  � RowDefinitions �� �� $
��1.1* ��� $
��0.2* �.+��� $��../images/shutup1.png���� $��1��$��30 30 30 30q����� *SalaryReportList+ �� View �� .P��� $��#�� �� DisplayMemberBinding �� *SpecialityId+��  �� Width$	 150��$��
Speciality�� �� *SpecialityName+�� $��	Total sum�� �� *
TotalSum+ �� StringFormat$
 {0}$���� $��2�� �� Orientation$ 
Horizontal=�.+��� $��14(�$��	40 0 55 0q�Total for all specialties:�� $��14(�$
��Bold"����� *
TotalSum+$
 {0}$��