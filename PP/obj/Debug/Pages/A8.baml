   M S B A M L   `   `   `  ����=  9PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PP.PagesPP.Pages  5          PP.Pages.A8   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PP.Pages     5        N� Title$  A8��5	      .��5      � ���	#FF8FF190 � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6`   ���	#FF8FF190   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	StudentID+6O     5      $ ФИО��6%   $ 2* 6O    62   �� *
FullName+6O     5      $ Дата рождения��6%   $ * 6\    6<   �� *DateOfBirth+6\     5      $ Возраст��6%   $ * 6N    66   �� *Age+6N     5      $" ID клас. руковод.��6%   $ * 6c    6@   �� *ClassTeacherID+6c     5      $ Клас. руковод.��6%   $ * 6h    6=   �� *ClassTeachers.FullName+6h     5      $ 
Класс��6%   $ * 6R    64   �� *	ClassName+6R   5      �� 5   
   -   5        	 ��Name$
	 edit��5      $��1��62   $��190,10,0,10q�6?   $
��Left=�6T   $	��150��6o   $��Bahnschrift Condensed)�6{   $��30(�6�   
�������.��6�   Изменить6�   �� 5   
   -   5        $	 
dobavlenie��5      $��1��6&   $��10q�63   $
��Left=�6?   $	��150��6Z   $��Bahnschrift Condensed)�6f   $��30(�6�   
�������.��6�   Добавить6�   �� 5   
   -   5        $��
BackButton��5      $��1��6<   $��10q�6I   $��Right=�6U   $	��150��6q   $��Bahnschrift Condensed)�6}   $��30(�6�   
�������.��6�   
Назад6�   �� 5   
   -   5        $	��del��5      $��1��6.   $��470,10,0,10q�6;   $
��Left=�6P   $	��150��6k   $��Bahnschrift Condensed)�6w   $��30(�6�   
�������.��6�   Удалить6�   5       5!      