   M S B A M L   `   `   `  ���� L  HDatabaseManagerV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DatabaseManagerV1DatabaseManagerV1  "    DatabaseManagerV1.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:DatabaseManagerV1     -     � WindowStartupLocation$  CenterScreen=� � Title$ 
MainWindow��$	��560��$
��1000�� � AllowsTransparency$
 True��
������  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.����  �� CornerRadius$ 8��$��1q�
�������
���   �._�]� $��1q�.+��� -    ��Name$ TopBar��
������ $ 8,8,0,0��$	��Top=�$	��Top=�._���  �� Orientation$ 
Horizontal=�$
��Left=�.+��� -   $ 
exitButton��$ 30��
���  ��$��5,0,0,0q�$��15��$��15�� � OverridesDefaultStyle$
 True���� -   $ minimizeButton��$ 30��
��� ���$��5,0,0,0q�$��15��$��15��$
 True���� -   $ maximizeButton��$ 30��
��� � �$��5,0,5,0q�$��15��$��15��$
 True���� 
�������$��Database Manager���� $	��Top=�
�������� 	 � ColumnDefinitions	 �� $��* ��� $��* �.+�&   System.Windows.Controls.DataGrid  -   
  Name$	
 dg1��$��0��$��Stretch=�$��Stretch=����	#FF050505   HeadersVisibility$
 None=����	#FFABADB3
���   �   CanUserAddRows$ False��$��20(�$��10q�$��1q�� $��1�����#151515$��Stretch=�$��Stretch=�.+�� $	��Top=�$��	20,0,20,0q�.+��� $��Select Target Database��
�������$��30��$��15(��� -    ��Name$ targetDbBox��$��Right=� �� SelectedIndex$ 0��$��Center=�$��15(�$	��200��$��30��$	��165���� -    ��Name$ 
queryentry��$��1q� �� TextWrapping$ NoWrap=� �� AcceptsReturn$
 True��" �� VerticalScrollBarVisibility$
 Auto=�
���   �
�������$��15(�$��10,35,10,47q��� $ 
Horizontal=�$��Center=�$��Bottom=�.+��� -	    ��Name$ startService��$��15(�$��Check Service��$	��100��$��Center=�$��10q��� -
   $ runQuery��$��15(�$	��Run��$��Center=�$��10q�$��	15,0,15,0q�$	��100�����	#FF25C953�� -   $ eQueriesBtn��$��15(�$��Executed Queries��$��Center=�$��10q�$	��100���� -   $ eqPanel��$ 	30,30,0,0��$��2q����#454545$	��400��$��0�����#151515$��Center=�$��Bottom=�._��  � RowDefinitions �� $
��auto ��� $��* �.+�� -    � Cursor$
 Hand��$��0�����	#00000000.+��� ���#454545$��5q�$��5��$ 2��$��50���� -    ��Name$ executedQueriesList��$��1��$��10q�
���������Z� ��Z� 