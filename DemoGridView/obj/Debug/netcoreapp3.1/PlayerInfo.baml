   M S B A M L   `   `   `  ����G  CDemoGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoGridViewDemoGridView  5   	       DemoGridView.PlayerInfo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DemoGridView     5   	     � Title$  
PlayerInfo��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DG_Player��5
         
IsReadOnly$
 true��6&   $��	0,0,0,275q�68      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Player Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *MemberInGameName+6_     5      $ Player Kills��6%   $ * 6U    6;   �� *Kills+6U     5      $ Player Deaths��6%   $ * 6X    6<   �� *Deaths+6X     5      $ 	Player KD��6%   $ * 6g    69   �� *KD+ �� StringFormat$ {0:N2}��6g   5      �� 5   
   -   5         ��Name$ CB_Select_Player��5      $
��Left=�6-   $��
10,164,0,0q�6H   $	��Top=�6\   $	��120��6t   �� 5   
   -   5        	 ��Name$	 Player_GetKill��5      $��Get Kill��6)   $
��Left=�6<   $��157,165,0,0q�6W   $	��Top=�6l   6�   �� 5   
   -   5        $	 Player_GetDeath��5      $��	Get Death��6*   $
��Left=�6>   $��227,165,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5        
 ��Name$
 TB_PlayerMessage��5      $
��Left=�6.   $��332,167,0,0q�6I   $
��Wrap=�6^   $	��Top=�6r     5   
   -   5        $ DG_Coach��5      $
 true��6%   $��
0,241,0,80q�67    5        5      $ Coach Team ��6%   $ * 6W    6:   �� *
TeamName+6W     5      $ Coach in game name��6%   $ * 6f    6A   �� *MemberInGameName+6f     5      $ Team Tactical Timeouts��6%   $ * 6k    6E   �� *TacticalTimeouts+6k   5      �� 5   
   -   5        $
 	TB_Update��5      $
��Left=�6'   $��
10,191,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   -   5        $ CB_Coach_Timeout��5      $
��Left=�6-   $��
10,359,0,0q�6H   $	��Top=�6\   $	��120��6t   �� 5   
   -	   5        $��Start Timeout ��5      $
��Left=�6*   $��157,361,0,0q�6E   $	��Top=�6Z   6r   �� 5    
   -
   5        $
 TB_Coach_Timeout��5       $
��Left=�6.   $��
10,386,0,0q�6I   $
��Wrap=�6]   $	��Top=�6q   �� 5!   
   -   5        $��Go Back��5!      $
��Left=�6#   $��692,361,0,0q�6>   $	��Top=�6S   $��53��6k   6v   5"      5#      