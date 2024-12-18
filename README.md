## 	&#9312;制作サイトのタイトル：
### makeTable

## &#9313;制作サイトの説明（40文字程度）：
### Xserverのデプロイ環境がまだ整っていないので、今回は.netを使ったwindowsアプリでmysqlの接続アプリを開発しました。プログラム言語はC#を使いました。テーブルに一行ずつデータをSQLコマンドで追加するのが面倒だと思ったので、コピペで貼り付けた複数のデータ行を一気に追加できるように開発しました。
https://github.com/TatsuyaFukunaga/makeTable/issues/1#issue-2746814633
[プログラム本体](assets/makeTable.zip)

## &#9314;工夫した点・こだわった点：
### データベースに接続すると、データベース上の複数のテーブルがドロップダウンで選択できて、テーブル接続ボタンを押すとテーブル内のデータ一覧が見れます。テーブル内の行を選択して削除ボタンを押すと、選択した行のデータが削除されます。また、テキストエリアにexcelなんかの表のデータを貼り付ければ何万行のデータでも一気に追加することが可能です。

## &#9315;難しかった点・次回トライしたこと（または機能）：
### Xserverのデプロイ環境を整えて、django->mysql接続、python webスクレイピング->dB登録に挑戦したい。

## &#9316;備考（感想、シェアしたいこと等なんでも）：
### さくらサーバーは制限が多く、自分の望むデプロイ環境を整えるために、Xserver VPSを契約した。
****