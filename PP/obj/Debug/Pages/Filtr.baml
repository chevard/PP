   M S B A M L   `   `   `  ����=  9PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PP.PagesPP.Pages  5          PP.Pages.Filtr   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PP.Pages     5        N� Title$  Filtr��5	      .��5      � ���	#FF8FF190 � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6`   ���	#FF8FF190   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	GradeID+6M     5      $ ID студента��6%   $ 2* 6X    6:   �� *	StudentID+6X     5      $ ФИО��6%   $ 2* 6Z    62   �� *Students5A.FullName+6Z     5      $ ID предмета��6%   $ * 6X    6:   �� *	SubjectID+6X     5      $ Предмет��6%   $ * 6a    66   �� *Subjects5A.SubjectName+6a     5      $ Оценка��6%   $ * 6O    65   �� *Grade+6O   5      �� 5   
   -   5        $��
BackButton��5      $��1��6<   $��508,18,0,18q�6I   $
��Left=�6^   $	��136��6y   $��Bahnschrift Condensed)�6�   $��30(�6�   
�������.��6�   
Назад6�   �� 5   
   -   5        $��
NextButton��5      $��1��6<   $��654,18,0,18q�6I   $
��Left=�6^   $	��136��6y   $��Bahnschrift Condensed)�6�   $��30(�6�   
�������.��6�   Вперед6�   �� 5   
   -   5        $��SortCMB��5      $��Center=�6"   $��1��6?   $��Center=�6L   $	��192��6g   $��40��6s   .@�5      �� $��По умолчанию��6   �� 5      $��5��6   �� 5       $��4��6   �� 5!      $��3��6   5"      �� 5#   
   $
��Left=�6   $��10,0,0,0q�6/   $��1��6A   $
��Wrap=�6N   $2��,Фильтрация по оценкам 5А��6b   $��Bahnschrift Condensed)�6�   $��30(�6�   $��Center=�6�   5$      5%      