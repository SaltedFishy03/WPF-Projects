   M S B A M L   `   `   `  ????D  @pizza app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:pizza_app	pizza_app  5   	   ;"clr-namespace:pizza_app.ViewModelspizza_app.ViewModels  6/       pizza_app.BuyPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:pizza_app     5   	   9
viewmodels"clr-namespace:pizza_app.ViewModels     6/     ? Title$  BuyPage??5   	   $	??450??6   $	??600??6'   
???   ?.??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??2??6   $??Center=?61   $??DIN BESTILLING??6N   $??20(?6g   
???????$??Heavy"?5      $??Italic$?6    ?? 5   
   $??1??6   $??2??6   $??3q?62   
??? ??? ?? CornerRadius$ 8??6_   ._?5      ?? -   5        $??lb_bestilling??5   B   
?????? 
???????$??1??6W   $??2??6d   $	??400??6x   $??5q?6?   ??6?   ?? *Buy+??5      ?? 5      .R?5      ?? $??3q?6!   
??? ???$ 8??6N   ._?5      ??  ?? Orientation$ 
Horizontal=?6)   $	??380??6B   .+?5   "   ?? ??6,   ?? *Name+?? 5   "   ??6,   ?? *Price+ ?? StringFormat$ 	 - {0} kr??5      5       5"      5$      5%      ?? 5'   
   -   5        $??btn_payment??5*      $??1??5(      $??1??5)      $??BETAL??5+      $??80??5,      $??30??5-      $??Right=?5.      $??Bottom=?5/      $??
0,10,10,10q?50      6!   51      52      