   M S B A M L   `   `   `  ����=  9PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PP.PagesPP.Pages  5          PP.Pages.Otchet7A   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PP.Pages     5        N� Title$  Otchet7A��5	      .��5      � ���	#FF8FF190 � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6`   ���	#FF8FF190   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	StudentID+6X     5      $ ФИО��6%   $ * 6O    62   �� *
FullName+6O     5      $ Средний балл��6%   $ * 6W    6;   �� *	Average+6W   5      �� 5   
   $
��Left=�6   $��50,0,0,0q�6/   $��1��6A   $
��Wrap=�6N   $	��7А��6b   $��Bahnschrift Condensed)�6m   $��30(�6�   $��Center=�6�   �� 5   
   -   5        $��
createOtch��5      $��1��6>   $��276,18,0,18q�6K   $
��Left=�6`   $	��191��6{   $��Bahnschrift Condensed)�6�   $��30(�6�   
�������.��6�   Создать отчет6�   �� 5   
   -   5        $��
NextButton��5      $��1��6<   $��642,18,0,18q�6I   $
��Left=�6^   $	��136��6y   $��Bahnschrift Condensed)�6�   $��30(�6�   
�������.��6�   Вперед6�   �� 5   
   -   5        $��
BackButton��5      $��1��6<   $��489,18,0,18q�6I   $
��Left=�6^   $	��136��6y   $��Bahnschrift Condensed)�6�   $��30(�6�   
�������.��6�   
Назад6�   5      5      