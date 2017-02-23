- [c sharp learning project at wpf](#c-sharp-learning-project-at-wpf)
	- [MVVMの考え方](#mvvmの考え方)
	- [構成](#構成)
	- [Memo](#memo)
		- [App.xaml](#appxaml)
	- [Reference](#reference)

# c sharp learning project at wpf
C# WPFの自己学習用プロジェクト

## MVVMの考え方
+ Model 各オブジェクトの値、処理等を実装していく
+ ViewModel Viewに値を渡したり、Modelの処理を呼び出す
+ View描画を行う

※ViewModelからViewへの値渡しはイベントを使用する

## 構成
MVVMを意識した構成
+ root
    + Models
        + クラスを配置していく
    + ViewModels
        + クラスを配置していく
    + Views
        + ウィンドウ、ページを配置していく
    + App.xaml からStartup等の項目を削除する
        ```diff
--- a/c-sharp-learning-project-wpf/App.xaml
+++ b/c-sharp-learning-project-wpf/App.xaml
@@ -1,9 +1,6 @@
<Application x:Class="c_sharp_learning_project_wpf.App"
               xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             [-xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"-]
             [-xmlns:local="clr-namespace:c_sharp_learning_project_wpf"-]
             [-StartupUri="MainWindow.xaml">-]
             {+xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">+}
    <Application.Resources>

    </Application.Resources>
        ```

## Memo
### App.xaml
+ ビルドアクション
    + ApplicationDefinition
        + App.xaml.cs にMainメソッドが自動生成される
    + Page
        + App.xaml.cs にMainメソッドが自動生成されなくなる
            > 実装する必要がある

## Reference
+ [MVVMのModelにまつわる誤解](http://ugaya40.hateblo.jp/entry/model-mistake)
+ [Webアプリケーション開発者から見た、MVCとMVP、そしてMVVMの違い](http://qiita.com/shinkuFencer/items/f2651073fb71416b6cd7)
+ [WPF4.5入門 その42 「WPFのプロパティシステム」](http://blog.okazuki.jp/entry/2014/08/17/220810)
+ [【WPF基礎】脱WPF初心者のための基礎知識　その２～ItemsSourceってなんぞ？～](http://inuinuwanwanilovecat.seesaa.net/article/395988498.html)
+ [C# 6.0時代の変更通知プロパティの書き方](http://blog.okazuki.jp/entry/2015/05/09/124333)
+ [MVVMでVMからVへの通知方法を思いついたので書いてみた](http://blog.okazuki.jp/entry/20110215/1297733885)
+ [MVVMに準拠する場合の、小画面の表示処理は、どこで行うべきか。](http://paul.hatenadiary.com/entry/2016/08/13/083521)
+ [データバインディングと非同期 – C# Advent Calendar 2014](http://www.kekyo.net/2014/12/21/4638)
+ [\[C# / WPF\] 最新のC# 6.0でMVVMパターンを実装する](http://qiita.com/nia_tn1012/items/de5c8f83f9a638f6e44e)
+ [\[C#\] ミリ秒単位のタイマーを作成する](http://www.moonmile.net/blog/archives/7519)
