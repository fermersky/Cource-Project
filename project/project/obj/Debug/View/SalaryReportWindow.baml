   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:project.Viewproject.View  5   	   %    project.View.SalaryReportWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:project.View     5   	     � Title$  SalaryReportWindow��5   	   $��538.013��6$   $��805.678��65   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $
��1.1* �6   6,   �� 5      $
��0.2* �6   6,   .+�5   
   �� $��../images/shutup1.png��6   61   �� 5   
   $��1��6   $��30 30 30 30q�6    ��65   �� *SalaryReportList+ �� View 5      �� 5      .P�5      �� $��#��5       �� DisplayMemberBinding 5      �� *SpecialityId+5      �� 5       �� Width$	 150��5      $��
Speciality��5       5      �� *SpecialityName+5      �� 5      $��	Total sum��5       5      �� *
TotalSum+ �� StringFormat$
 {0}$��5      5      5      �� 5    
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�5!      �� $��14(�6   $��	40 0 55 0q�6&   Total for all specialties:6U   �� 5"      $��14(�6   $
��Bold"�6&   ��68   �� *
TotalSum+$
 {0}$��6i   5#      5$      5%      