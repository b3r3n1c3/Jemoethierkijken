   M S B A M L   `   `   `  ����G  CDemoGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoGridViewDemoGridView  5   	       DemoGridView.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DemoGridView     5   	     � Title$  DataGrid Tutorial��5   	   
������ $	��824��6<   $	��800��6I   .��5	      � $��0,0,0,-6q�6    � ColumnDefinitions 5
   
   �� 5      $
��425* �6   �� 5      $
��376* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid1��5      $��10,24,10,422q�6&      
IsReadOnly$
 true��6<   $��2��6N      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Team Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
TeamName+6U     5      $ 
Start Year��6%   $ * 6W    69   �� *	StartYear+6W   5      �� 5   
   -   5         ��Name$ AddNewTeamButton��5      $��Add new Team��6+   $
��Left=�6B   $��
10,504,0,0q�6]   $	��Top=�6q   6�   �� 5   
   -   5        	 ��Name$	 AddTeamName��5      $
��Left=�6'   $��
10,441,0,0q�6B   
 �� TextWrapping$

 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��	Team Name��6�   �� 5   
   -   5        $	 AddStartYear��5      $
��Left=�6(   $��
10,472,0,0q�6C   $��
Start Year��6W   $

 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   $
��Left=�6   
����� �$��
10,410,0,0q�6A   $��Add A New Team��6U   $
��Wrap=�6k   $	��Top=�6   �� 5   
   $
��Left=�6   
����� �$��150,410,0,0q�6A   $��Delete a Team��6V   $
��Wrap=�6k   $	��Top=�6   �� 5   
   -   5         ��Name$	 CB1��5      $
��Left=�6    $$��150                   ,441,0,0q�6;   $	��Top=�5      $	��120��65   �� 5   
   -   5        $ DeleteTeamButton��5      $��Delete��6+   $
��Left=�6<   $"��150                 ,504,0,0q�6W   $	��Top=�5       J� RenderTransformOrigin$ 
0.48,0.052&�63   6V   �� 5   
   -   5        $ TeamInfoButton��5      $��Team member info��6*   $
��Left=�6E   $��174,441,0,0q�6`   $	��Top=�6u   $ -0.265,-1.977&�6�   $��21��6�   $	��128��6�   $��1��6�   �� 5   
   -   5        $ UpdateTeamButton��5      $��Update team��6+   $��394,549,282,207q�6A   $	��Top=�6y   $��2��6�   �� 5   
   $
��Left=�6   $��26��6/   
����� �$��300,410,0,0q�6N   $��Update a team��6c   $
��Wrap=�6x   $	��Top=�6�   $	��100��6�   �� 5    
   $
��Left=�6   $��26��6/   
����� �$��300,437,0,0q�6N   $��Select a team: ��6c   $
��Wrap=�6z   $	��Top=�6�   $	��100��6�   $ 
0.49,0.828&�6�   �� 5!   
   $
��Left=�6   $��26��6/   
����� �$��300,472,0,0q�6N   $��Team name: ��6c   $
��Wrap=�6v   $	��Top=�6�   $	��100��6�   �� 5"   
   $
��Left=�6   $��26��6/   
����� �$��300,501,0,0q�6N   $��Start Year: ��6c   $
��Wrap=�6w   $	��Top=�6�   $	��100��6�   �� 5#   
   -	   5        $	 CB2��5#      $
��Left=�6    $��394,441,0,0q�6;   $	��Top=�6P   $	��120��6h   $��2��6t   �� 5$   
   -
   5        $	 TB_Update_TN��5$      $

 Wrap=�6)   $��395,472,285,0q�6=   $	��Top=�6T   $	��120��6l   $��18��6x   $��2��6�   �� 5%   
   -   5        $	 TB_Update_SY��5%      $

 Wrap=�6)   $��395,504,285,0q�6=   $	��Top=�6T   $	��120��6l   $��2��6x   �� 5&   
   -   5         ��Name$ Update_Error_TN��5&      $�� ��6-   
����� �$
��Wrap=�6H   $��300,582,234,169q�6\   $��2��6u   �� 5'   
   -   5        $ Update_Error_SY��5'      $�� ��6-   
����� �$
��Wrap=�6H   $��300,614,234,137q�6\   $��2��6u   �� 5(   
   -   5        $ BT_PlayerInfo��5(      $��Player Info��6(   $��1��6>   $
��Left=�6N   $��174,467,0,0q�6i   $	��Top=�6~   $	��128��6�   �� 5)   
   -   5        $ TB_Add_Error��5)      
����� �$
��Left=�6<   $��
10,549,0,0q�6W   $
��Wrap=�6k   $	��Top=�6   $	��120��6�   5*      5,      