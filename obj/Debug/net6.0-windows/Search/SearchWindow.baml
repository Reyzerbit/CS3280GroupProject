   M S B A M L   `   `   `  ����F  BGroupPrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GroupPrject.SearchGroupPrject.Search  5   	   b ^PresentationFramework.Aero2, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	   %    GroupPrject.Search.SearchWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:GroupPrject.Search     5   	   ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	   -   5          � Title$  SearchWindow��5	   	   $	��450��6   $	��800��6+    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  TextBox.Static.Background �� Color  ComboBoxEditableTextBox �� 
TargetType �� 
TargetType	 ��Name  ComboBox.Static.Background
 �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border  ComboBox.Static.Glyph ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background *	 &ComboBox.Static.Editable.Button.Border !
 ComboBox.MouseOver.Background  ComboBox.MouseOver.Border  ComboBox.MouseOver.Glyph * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border   ComboBox.Disabled.Background  ComboBox.Disabled.Border  ComboBox.Disabled.Glyph ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBoxToggleButton ��Name F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� Mode �� 
TargetName P� Property P� Value   ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency5  /Microsoft.Windows.Themes.SystemDropShadowChrome  Name   Color  �� MaxDropDownHeight! �� ElementName" �� ClearTypeHint# ��Name$ ��Name% ��Name-  'System.Windows.Input.KeyboardNavigation&   DirectionalNavigation' d�Name( d� 	IsChecked) �� Mode* ��Name+ �� 
IsReadOnly, P� 
SourceName- ]� 
Conditions. �� Property ! ComboBoxTemplate/ ��Name#0 �� SelectionBoxItemStringFormat1 �� ContentStringFormat2 �� SelectionBoxItemTemplate3 �� SelectionBoxItem4 J� IsHitTestVisible5 �� Triggers*  $System.Windows.Controls.DataGridCell&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader:  4System.Windows.Controls.Primitives.DataGridRowHeader��%Q2  &	        &	 �     &	 �     &	     &	 �    &	 �    &	 �    &	     &	 /    &		 T    &	
 y    &	     &	 8    &	 [    &	 ~    &	 �    &	 =    &	 `    &	 �    &	     &	 B    &	 e    &	 �    &	 $    &	 G    &	 j    &	 �    &	 �    &	 �    &	 �    &	 	    &	 @	    7  7  7  7  7  7  7 	 7  7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	  �    7  7  7  &	! y!    7  '�� A*    7   7  7  7 ! 7   '� -    '  m-    '  �-    '  3.    '  �.    '�� �.    '�� q/    '�� �/    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ #FFFFFF��6<   �� 5   
   " ��60   .�5      ��  �@�OverridesDefaultStyle$
 true��66   �� 5       �@J�	AllowDrop$
 true��6*   �� 5       � ��$ 0��6)   �� 5       � ��$ 0��6*   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5       �� 5!      " ��6&   .R�5"      �� $	 PART_ContentHost��6'   
������ $|�false��6Z   $��Hidden=�6l   $��Hidden=�6�   5#      5%      5&      �� 5'   
   $	
 0,1&�6A   $	 0,0&�6P   .��5(      � $ #2f1b12��6   $	 0.0Q�6+   � 5)      $ #714423��6   $	 1.0Q�6+   5*      �� 5+   
   $ 	#FFACACAC��69   �� 5,   
   $ 	#FF606060��68   �� 5-   
   $ 	#FFFFFFFF��6F   �� 5.   
   $ 	#FFABADB3��6B   �� 5/   
   $ Transparent��6M   �� 50   
   $ Transparent��6I   �� 51   
   $	
 0,1&�6D   $	 0,0&�6S   .��52      � $ 	#FFECF4FC��6   $	 0.0Q�6-   � 53      $ 	#FFDCECFC��6   $	 1.0Q�6-   54      �� 55   
   $ 	#FF7EB4EA��6<   �� 56   
   $ 	#FF000000��6;   �� 57   
   $ 	#FFFFFFFF��6I   �� 58   
   $ 	#FF7EB4EA��6E   �� 59   
   $	
 0,1&�6T   $	 0,0&�6c   .��5:      � $ 	#FFEBF4FC��6   $	 0.0Q�6-   � 5;      $ 	#FFDCECFC��6   $	 1.0Q�6-   5<      �� 5=   
   $ 	#FF7EB4EA��6L   �� 5>   
   $	
 0,1&�6B   $	 0,0&�6Q   .��5?      � $ 	#FFDAECFC��6   $	 0.0Q�6-   � 5@      $ 	#FFC4E0FC��6   $	 1.0Q�6-   5A      �� 5B   
   $ 	#FF569DE5��6:   �� 5C   
   $ 	#FF000000��69   �� 5D   
   $ 	#FFFFFFFF��6G   �� 5E   
   $ 	#FF569DE5��6C   �� 5F   
   $	
 0,1&�6R   $	 0,0&�6a   .��5G      � $ 	#FFDAEBFC��6   $	 0.0Q�6-   � 5H      $ 	#FFC4E0FC��6   $	 1.0Q�6-   5I      �� 5J   
   $ 	#FF569DE5��6J   �� 5K   
   $ 	#FFF0F0F0��6?   �� 5L   
   $ 	#FFD9D9D9��6;   �� 5M   
   $ 	#FFBFBFBF��6:   �� 5N   
   $ 	#FFFFFFFF��6H   �� 5O   
   $ 	#FFBFBFBF��6D   �� 5P   
   $ Transparent��6O   �� 5Q   
   $ Transparent��6K   �� 5R   
   " d�6-   .�5S      ��  �@�OverridesDefaultStyle$
 true��66   �� 5T       � ��$ false��6*   �� 5U       � |�$ false��6*   �� 5V       �@��	ClickMode$ Press=�6*   �� 5W       � �� 5X      �� 5Y      " d�6&   .R�5Z      �� $ templateRoot��6!   8��  8�� #��z��6�   $
 true��6�   ._�5[      �� $ splitBorder��6%   
������ $��1q�6T   $��Right=�6h   $��0q�6�   $
 true��6�   #��� r�6�   ._�5\   "   F� $ arrow��6'   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5]      5^       5_      ^� 5`       5a   "   �� 5b   &    60   �� *
IsEditable+ �� " �� true6�   �� 5c   &    60   �� *IsMouseOver+ �� $
 Self=�	 false6{   �� 5d   &    60   �� *	IsPressed+ �� $
 Self=�	 false6y   �� 5e   &    60   �� *	IsEnabled+ �� $
 Self=� true6y   .0�5g   "   �� $ templateRoot��6?   8   � ��6Y   �� 5h   "   $ templateRoot��6@   8   � ��6Z   �� 5i   "   $ splitBorder��6?   8   � ��6X   �� 5j   "   $ splitBorder��6@   8   � ��6Y   5k      P� 5l       �@J�IsMouseOver$
 true��6=   . �5m   "   �� $ arrow��69   8   � ��6L   5n      ^� 5o       5p   "   �� 5q   &    60   �� *IsMouseOver+ �� $
 Self=� true6{   �� 5r   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5t   "   �� $ templateRoot��6?   8   � ��6Y   �� 5u   "   $ templateRoot��6@   8 	  � ��6Z   5v      ^� 5w       5x   "   �� 5y   &    60   �� *IsMouseOver+ �� $
 Self=� true6{   �� 5z   &    60   �� *
IsEditable+ �� " �� true6�   .0�5|   "   �� $ templateRoot��6?   8 
  � ��6Y   �� 5}   "   $ templateRoot��6@   8   � ��6Z   �� 5~   "   $ splitBorder��6?   8   � ��6X   �� 5   "   $ splitBorder��6@   8   � ��6Y   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsPressed+ �� $
 Self=� true6y   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsPressed+ �� $
 Self=� true6y   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� $
 Self=�	 false6y   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� $
 Self=�	 false6y   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      5�      5�      5�      �� 5�   
   " ��6;   .R�5�      � $ templateRoot��6   $
 true��6)    5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6   $
 true��6,   $��2��6F   $��Bottom=�6�   #��� .�6�   ��6Z   �� *IsDropDownOpen+ �� $ TemplatedParent=�.��5�        $ shadow��63   $ Transparent��6C   #��z  6�   ��6W   �� *ActualWidth+$! templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   #��� ��6   $��1q�6�   ._�5�      �� $	 DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $" Enabled=�65   .+�5�   &   �� $# canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $$ 
opaqueRect��64   ��6H   �� *
Background+$! dropDownBorder����6�   �� *ActualHeight+$! dropDownBorder����6�   �� *ActualWidth+$! dropDownBorder��5�   '   �� 5�   &   $% ItemsPresenter��65   $& 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $' toggleButton��6   #��z��65   #��z��6_   #��z��6�   $��2��6�   8��  ( 6�   �� *IsDropDownOpen+$) TwoWay=� �� $ TemplatedParent=�6;  �� 5�      $ border��6   8�� #��z��6a   ._�5�      �� $* PART_EditableTextBox��6   #��z��6<   #��z��6�   8�� #��z��62  + 6�   �� *
IsReadOnly+ �� $ TemplatedParent=�62  5�      5�       5�      P� 5�       � {�$ false��6/   . �5�      �� $ border��60    �@J�Opacity$
 0.56Q�6D   5�      P� 5�       �@J�IsKeyboardFocusWithin$
 true��6;   . �5�      ��  � �� �#DEAF8463   5�      P� 5�      $, 
PART_Popup��63    �@�HasDropShadow$
 true��6K   . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5�       �@��HasItems$ false��6.   . �5�      �� $ dropDownBorder��6/    � ��$ 95��6K   5�      ]� 5�      - 5�      �� 5�      . �@��
IsGrouping$
 true��6:   �� 5�      ". �@%�IsVirtualizingWhenGrouping$ false��6\   ./�5�      ��  � ��$ false��6F   5�      P� 5�      $, DropDownScrollViewer��6C    � ��$ false��6e   . �5�      �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$! DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��64    6L   �� *HorizontalOffset+$! DropDownScrollViewer�� �@��Left5�      5�      �� 5�   
   " ��63   .R�5�      � $ templateRoot��6   $
 true��6)    5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6   $
 true��6,   $��2��6F   $��1q�6�   $��Bottom=�6�   #��� .�6�   ��6Z   �� *IsDropDownOpen+$) TwoWay=� �� $ TemplatedParent=�.��5�        $ shadow��63   $ Transparent��6C   #��z  6�   ��6W   �� *ActualWidth+$! templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   #��� ��6   $��1q�6�   ._�5�      �� $	 DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $" Enabled=�65   .+�5�   &   �� $# canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $$ 
opaqueRect��64   ��6H   �� *
Background+$! dropDownBorder����6�   �� *ActualHeight+$! dropDownBorder����6�   �� *ActualWidth+$! dropDownBorder��5�   '   �� 5�   &   $% ItemsPresenter��65   $& 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $' toggleButton��6   #��z��65   #��z��6_   #��z��6�   $��2��6�   8��  ( 6�   �� *IsDropDownOpen+$) TwoWay=� �� $ TemplatedParent=�6;  �� 5�      $/ contentPresenter��6#   #1 z0 6=   #��z2 6�   #��z3 6�   #��z��6�   #��z��6-  $4 false��6p  #��z��6�  # z 6�  #��z��6�  5�       5�      P� 5�      $, 
PART_Popup��63    �@�HasDropShadow$
 true��6K   . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5       �@��HasItems$ false��6.   . �5     �� $ dropDownBorder��6/    � ��$ 95��6K   5     ]� 5     - 5     �� 5     . �@��
IsGrouping$
 true��6:   �� 5     ". �@%�IsVirtualizingWhenGrouping$ false��6\   ./�5     ��  � ��$ false��6F   5	     P� 5
     $, DropDownScrollViewer��6C    � ��$ false��6e   . �5     �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$! DropDownScrollViewer�� �@��Top�� 5     $ 
opaqueRect��64    6L   �� *HorizontalOffset+$! DropDownScrollViewer�� �@��Left5     5     �� 5  
   " ��6   .�5     ��  �@�FocusVisualStyle8   61   �� 5      � ��8  6+   �� 5      � ��8  6,   �� 5      � ��# � ��6+   �� 5      � ��$ 1q�60   �� 5      � ��$
 Auto=�6K   �� 5      � ��$
 Auto=�6I   �� 5      � ��$ 6,3,5,3q�6(   �� 5      � ��$
 true��6>   �� 5      �@��PanningMode$
 Both=�69   �� 5      �@��IsFlicksEnabled$ False��67   �� 5      � ��8  6)   �� 5      � �� �	#FFDEAF846+   5 5     P� 5      �@��
IsEditable$
 true��60   . �5      ��  � ��$ false��62   �� 5!      � ��$ 2q�60   �� 5"      � ��8  61   5#     5%     �� 5'  
   " �6   .�5(     ��  � �� �#4C64446+   5)     �� 5*  
   "  6   .�5+     ��  � �� �#4D2D186+   �� 5,      � �� �#CABA9C6+   5-     �� 5/  
   "  6   .�50     ��  � �� �#7144236+   51     �� 52  
   "  6   .�53     ��  � �� �#7144236+   �� 54      � �� �#CABA9C6+   55     �� 56  
   "  6   .�57     ��  � �� �#7144236+   58     �� 59  
   " ��6   .�5:     ��  � �� �#1028206+   �� 5;      � �� �#CABA9C6+   5<     �� 5=  
   " ��6   .�5>     ��  � �� �	#FFDEAF846+   5?     �� 5@  
   " ��6   .�5A     ��  � �� �#2f1B126+   5B     5C     .��5E     � .+�5F  
   �� -   5        6 ��Name$6 	cboInvNum��5F     $
��Left=�6&   $��
162,51,0,0q�6A   $	��Top=�6U   $	��120��6m   6y   �� 5G  
   -   5        $6 
cboInvDate��5G     $
��Left=�6'   $��
420,51,0,0q�6B   $	��Top=�6V   $	��120��6n   6z   �� 5H  
   -   5        $6 cboInvCharge��5H     $
��Left=�6)   $��
653,51,0,0q�6D   $	��Top=�6X   $	��120��6p   6|     5I  
   -   5        7  Name$7 	dgResults��5I     $��47,111,43,98q�6Q   ���	#FF0E0C0C8   
IsReadOnly$
8 True��6~   �� 5J  
   -   5        9 ��Name$9 btnSelectInvoice��5J     $��Select Invoice��6+   $
��Left=�6D   $��223,369,0,0q�6_   $	��Top=�6t   $��39��6�   $��91��6�   �� 5K  
   -   5        $9 btnClear��5K     $��Clear��6#   $
��Left=�63   $��441,369,0,0q�6N   $	��Top=�6c   $��39��6�   $��91��6�   �� 5L  
   -   5        : ��Name$: 	lblInvNum��5L     $��Invoice Number:��6#   $
��Left=�6=   $��	55,49,0,0q�6X   $	��Top=�6k   �� 5M  
   -	   5        $: 
lblInvDate��5M     $��Invoice Date:��6$   $
��Left=�6<   $��
327,49,0,0q�6W   $	��Top=�6k   �� 5N  
   -
   5        $: lblTotalCharge��5N     $��Total Charges:��6(   $
��Left=�6A   $��
567,49,0,0q�6\   $	��Top=�6p   �� 5O  
   -   5        $: lblSelectStatus��5O     $�� ��6*   $
��Left=�65   $��
47,376,0,0q�6P   $	��Top=�6d   5Q     5R     