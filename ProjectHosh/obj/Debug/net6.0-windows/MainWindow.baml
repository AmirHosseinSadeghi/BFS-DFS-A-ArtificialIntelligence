   M S B A M L   `   `   `  ����F  BProjectHosh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ProjectHoshProjectHosh  5   	       ProjectHosh.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ProjectHosh     5   	     � Title$  Search Algoritm��5   	   $	��800��6!   $	��920��6.    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      � 
�����p�.+�5   
   � -   5         �Name$	 Map��5      $��	0,0,0,200q�6   5      �� 5   
   -   5         ��Name$ GeneratePatternbtn��5      $��Generate Pattern��6-   $��18(�6H   $
��Left=�6V   $��
10,609,0,0q�6q   $	��Top=�6�   $��60��6�   $	��150��6�   6�   �� 5   
   -   5        $ HandyPatternbtn��5      $��Handy Pattern��6*   $��18(�6B   $
��Left=�6P   $��
10,692,0,0q�6k   $	��Top=�6   $��60��6�   $	��150��6�   6�   �� 5   
   -   5        $ Clearbtn��5      $��Clear��6#   $��20(�63   $
��Left=�6A   $��174,692,0,0q�6\   $	��Top=�6q   $��60��6�   $��80��6�   6�   �� 5   
   -   5        $ 	Searchbtn��5      $��Search��6$   $��20(�65   $
��Left=�6C   $��174,611,0,0q�6^   $	��Top=�6s   $��60��6�   $��80��6�   6�   �� 5   
   $��Select Algoritm :��6   $��20(�6,   $
��Left=�6:   $��278,611,0,0q�6U   $	��Top=�6j   $��40��6�   $	��160��6�   �� 5   
   -   5         ��Name$ combobox��5      $��25(�6%   $
��Left=�63   $��460,611,0,0q�6N   $	��Top=�6c   $	��140��6{   $��41��6�    J� RenderTransformOrigin$ 0.523,0.586&�6�   .@�5      �� $	��BFS��6    �� 
IsSelected$
 True��6)   �� 5      $	��DFS��6   �� 5      $��A*��6   5      �� 5   
   $��Time of Execution : ��6   $��20(�6/   $
��Left=�6=   $��616,609,0,0q�6X   $	��Top=�6m   $��50��6�   $	��180��6�   �� 5   
   -   5         ��Name$ OpenNodesLb��5      $��20(�6%   $
��Left=�63   $��835,692,0,0q�6N   $	��Top=�6c   $��50��6{   $��70��6�   $ 
1.21,0.345&�6�   �� 5   
   $��Opened Nodes : ��6   $��20(�6*   $
��Left=�68   $��616,697,0,0q�6S   $	��Top=�6h   $��50��6�   $	��180��6�   �� 5   
   -   5        $ TimeLb��5      $��20(�6    $
��Left=�6.   $��835,601,0,0q�6I   $	��Top=�6^   $��50��6v   $��70��6�   $ 1.384,0.442&�6�   5      5      