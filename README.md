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
