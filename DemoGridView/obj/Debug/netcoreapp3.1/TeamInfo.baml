   M S B A M L   `   `   `  ����G  CDemoGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoGridViewDemoGridView  5   	       DemoGridView.TeamInfo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DemoGridView     5   	     � Title$  TeamInfo��5   	   $	��627��6   $	��800��6'   .��5	      � $��	0,0,0,129q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid2��5
      $��Center=�6&   $	��246��6C   $	��Top=�6P   $	��780��6h   $��0,10,0,0q�6t      
IsReadOnly$
 true��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Team Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
TeamName+6U     5      $ 
Start Year��6%   $ * 6W    69   �� *	StartYear+6W     5      $ Teammember Member Name��6%   $ * 6d    6E   �� *
MemberName+6d     5      $ Teammember Age��6%   $ * 6[    6=   �� *	MemberAge+6[     5      $ In Game Name��6%   $ * 6`    6;   �� *MemberInGameName+6`   5      �� 5   
   $
��Left=�6   $��
10,261,0,0q�6/   $��Add a teammember: ��6C   $
��Wrap=�6]   $	��Top=�6q   �� 5   
   $
��Left=�6   $��279,261,0,0q�6/   $��Delete a teammember: ��6D   $
��Wrap=�6a   $	��Top=�6u   �� 5   
   $
��Left=�6   $��448,260,0,0q�6/   $��Update a teammember: ��6D   $
��Wrap=�6a   $	��Top=�6u   �� 5   
   -   5         ��Name$ 	CB_Add_TN��5   O   $
��Left=�6   $��20��6.   $��144,278,0,0q�6:   $	��Top=�6b   $	��120��6z   �� 5   
   -   5        $ CB_Delete_TM��5   O   $
��Left=�6   $��20��6.   $��280,278,0,0q�6:   $	��Top=�6e   $	��153��6}   �� 5   
   -   5        $ CB_Update_TM��5   O   $
��Left=�6   $��20��6.   $��448,278,0,0q�6:   $	��Top=�6e   $	��153��6}   �� 5   
   -   5         ��Name$ TBox_Add_MN��5      $
��Left=�6'   $��144,308,0,0q�6B   	 �� TextWrapping$
	 Wrap=�6W   $	��Top=�6k   $	��120��6�   �� 5   
   -   5        $ TBox_Add_Age��5      $
��Left=�6(   $��144,331,0,0q�6C   $
	 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ TBox_Add_IGN��5      $
��Left=�6(   $��144,355,0,0q�6C   $
	 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ TBox_Update_MN��5      $
��Left=�6*   $��574,308,0,0q�6E   $
	 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 5   
   -	   5        $ TBox_Update_Age��5      $
��Left=�6+   $��574,331,0,0q�6F   $
	 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   -
   5        $ TBox_Update_IGN��5      $
��Left=�6+   $��574,354,0,0q�6F   $
	 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5    
   -   5        
 ��Name$
 TB_Add_Team��5       $
��Left=�6)   $��
10,282,0,0q�6D   $��Team:��6X   $
��Wrap=�6e   $	��Top=�6y    J� RenderTransformOrigin$ 
0.476,0.41&�6�   �� 5!   
   -   5        $
 	TB_Add_MN��5!      $
��Left=�6'   $��
10,308,0,0q�6B   $��Teammember Name:��6V   $
��Wrap=�6n   $	��Top=�6�   �� 5"   
   -   5        $
 TB_Update_MN��5"      $
��Left=�6*   $��448,308,0,0q�6E   $��Teammember Name:��6Z   $
��Wrap=�6r   $	��Top=�6�   �� 5#   
   -   5        $
 
TB_Add_Age��5#      $
��Left=�6(   $��
10,334,0,0q�6C   $��Teammember Age:��6W   $
��Wrap=�6n   $	��Top=�6�   �� 5$   
   -   5        $
 TB_Update_Age��5$      $
��Left=�6+   $��448,334,0,0q�6F   $��Teammember Age:��6[   $
��Wrap=�6r   $	��Top=�6�   �� 5%   
   -   5        $
 
TB_Add_IGN��5%      $
��Left=�6(   $��
10,355,0,0q�6C   $��In Game Name:��6W   $
��Wrap=�6l   $	��Top=�6�   $	��109��6�   �� 5&   
   -   5        $
 TB_Update_IGN��5&      $
��Left=�6+   $��448,355,0,0q�6F   $��In Game Name:��6[   $
��Wrap=�6p   $	��Top=�6�   �� 5'   
   -   5         ��Name$ 	BT_Add_TM��5'      $��Add Teammember��6$   $
��Left=�6=   $��144,378,0,0q�6X   $	��Top=�6m   $	��120��6�   6�   �� 5(   
   -   5        $ BT_Delete_TM��5(      $��Delete Teammember��6'   $
��Left=�6C   $��283,307,0,0q�6^   $	��Top=�6s   $ 0.126,-0.349&�6�   $	��120��6�   6�   �� 5)   
   -   5        $ BT_Update_TM��5)      $��Update Teammember��6'   $
��Left=�6C   $��448,378,0,0q�6^   $	��Top=�6s   $	��129��6�   6�   �� 5*   
   -   5        $��Go back��5*      $
��Left=�6#   $��19��6>   $��700,263,0,0q�6J   $	��Top=�6_   $��80��6w   6�   �� 5+   
   -   5        $
 TB_Update_Error��5+      $
��Left=�6-   $��21��6H   $��448,403,0,0q�6T   $
��Wrap=�6i   $	��Top=�6}   $	��246��6�   �� 5,   
   -   5        $
 TB_Update_Error_Age��5,      $
��Left=�61   $��21��6L   $��448,429,0,0q�6X   $
��Wrap=�6m   $	��Top=�6�   $	��246��6�   �� 5-   
   -   5        $
 TB_Update_Error_IGN��5-      $
��Left=�61   $��21��6L   $��448,455,0,0q�6X   $
��Wrap=�6m   $	��Top=�6�   $	��246��6�   �� 5.   
   -   5        $
 TB_Add_Error��5.      $
��Left=�6*   $��
16,416,0,0q�6E   $
��Wrap=�6Y   $	��Top=�6m   �� 5/   
   -   5        $
 TB_Delete_error��5/      $
��Left=�6-   $��280,340,0,0q�6H   $
��Wrap=�6]   $	��Top=�6q   51      52      