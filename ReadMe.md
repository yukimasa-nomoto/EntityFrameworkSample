2021/12/1
これを経て、「EntityFrameworkSample」を作ってみる
	・Domain
		Userをつくる	Domainフォルダーをまた作る Usersフォルダーを作る
			ここで悩む。アノテーションつけれないし、プロパティーをgetだけに出来ない
			他のcleanArchitectureのsqlServer版をなんとかOracleで動かないかをやってみる
				→EntityFrameworkをインストール
					dboがないとか出る。
					→スキーマをOnModelCreatingに追加で成功
						なんかデータも作ってくれた
			↓
			悩みの結果を考える		
				混合して考える
					DomainにCustomersフォルダー、Customerを作る
						→結局 Setter Getterで対応する
						Commonフォルダーも
							IEntity作成済み
	・Application			
		Customersを作成			
			Commands	
				CreateはCommandでできそうならやってみたい。kokokara
				無理ならUseCase
				CreateCustomerフォルダー作成
					CreateCustomerModel作成
					ICreateCustomerModel作成
					CreateCustomerCommand作成
					Factoryフォルダー作成
						ICustomerFactory作成
						CustomerFactory作成

			Queries
				両方作成
				GetCustomerList作成
					CustomerModel作成		これは表示用？
					IGetCustomersListQuery	取得用？
					GetCustomersListQuery	作成
						IDatabaseServiceを入れる
		Microsoft.EntityFrameworkCoreインストール
		Interfaces
			（Domainを参照に追加）
			DB等のデータ取得用作成			本来はIRepository　各テーブルごと？
			IDatabaseService				全テーブルを含む	Databaseと決めつけてる
				IDbSetがうまくいかない				
					→DbSetに変更(FramworkCoreなので)
				ここはCustomerを使う。
	・Persistence	
		(Applicationを参照に追加)
		OracleEntityFrameworkCoreインストール
		DatabaseService作成
		InitialCreateも行ってみる(Migration)	
			Core.Design(ver6)
			Core.tool(ver6)
			両方インストール
			パッケージマネージャーコンソール上で
				Add-Migration InitialCreate　
					失敗	
						→スタートアッププロジェクトと、「既定のプロジェクト」変更
						↓
						失敗 なんか接続設定が必要？？				kokokara
						Method 'get_QueryProvider' in type 'Microsoft.EntityFrameworkCore.Storage.Internal.RelationalDatabaseFacadeDependencies'
							→mix diffrence version?
							↓
							成功した。
								Applicationにインストールした「Microsoft.EntityFrameworkCore」がver7で違っていた ver6の最後に設定
								（Oracle繋がってなくても良かった）
				↓
				Update-Database
					Oracleにテーブル作成成功
	・Presentation作成
		（Formとは分けて作成してみる）
		 (Application、Domain、Persistenceを参照に追加)

		CustomersのControllerやViewModel等、UseCaseでみたやつもうまく混ぜて作ってみる

		・Microsoft.Extensions.DependencyInjectionをインストール	これもver6.0.1に落とす
		↓
		ここで競合起きてる事を発見
		Microsoft.EntityFrameworkCore.Relational" の異なるバージョン間で、解決できない競合が見つかりました
		ツール→オプション→プロジェクト及び→ビルド→msbuild プロジェクトビルド 出力 詳細に
		初期が6.0.3を選んでるっぽい。他のDLLが6.0.11をつかってる。
		↓
		Microsoft.EntityFrameworkCore.Relationalの6.0.11をnugetでインストール（解決まで、３時間ぐらいかかった）

		・StartUpを作成
		・Customersフォルダー作成
			Modelsフォルダー作成
				CreateCustomerViewModel作成
			Servicesフォルダー作成
				ICreateCustomerViewModelFactory 作成
				CreateCustomerViewModelFactory 作成
			CustomerController作成
				UseCase使うかは保留。
					まずは、AppicationのCommandでやってみたい

				表示ロジック
					Indexで作成。

				作成ロジック
					Createで作成

				これを画面からCallしてみる
						
					Indexで表示
						→OK
					Createで作成→Indexで再表示
						→OK
				最後にICustomerControllerが必要か？
					→実装

				useCaseみたいにならない？　callbackがない		kokokara
					UserCreateSubjectみたいなのがない。どこに置くべき？

	・GUISに（Presentationを参照に追加）
		Startup.Runをコール
		
			

		
		


	・IRepositoryは作る？作らない？


	・Infrastructure
		Userのマイクグレーションを作る
		
	・SalesのUpdateも混合する
		CustomersのUpdateも

	・表示をどうやるか？画面に実装するか？別のControlLibrary作るか？

	・最後は.net core のCleanArchitectureをみて、考え方を合わせたい

	DependencyInjectionを考える

2022/11/24
コンソールで、サンプルやってみる
https://www.youtube.com/watch?v=SryQxUeChMc&t=2s
	Nugetで
		・ODP frameworkcore
		・core design
		・core tools
	パッケージマネージャーで(これtoolあるからかな)
		Add-Migration InitialCreate　
			→失敗。既定のプロジェクトを変更で成功
			Migrationsフォルダー製作済み
		Update-Database
			→失敗。関連キーの列名が長かったので変更
				→成功
	Customer Entityに項目追加したときのマイグレーション
		Add-Migration AddEmail		名前変更
		↓
		Update-Database		おそらく新しい方を選んでくれてる気がする
			成功
	・Update Order By
		→OK
https://www.youtube.com/watch?v=DCYVfLT5_QI
	Scaffoloding data existing database
	↓
	パッケージマネージャー
		Scaffold-DbContext "User ID=awc; Password=awc; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=DAS)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));" Oracle.EntityFrameworkCore -ContextDir Data2 -OutputDir Models2
		→OK
		↓
		最後に -DataAnnotationをつける
	↓
	２種類のアプローチがあるみたい
		・作る場所変更 追記
			Models2/Generated -ContextNamespace　ContosoPizza.Data2 -Namespace ContosoPizza.Models2
			そもそもPartialClassになっている。
			上の階層に同じクラスを使って、追加箇所を記載可能
		・
次はAsp.netCoreの動画だが未実施。
	connectionstringを秘密にしたり、各種テーブルをScaffoldingしたり
https://www.youtube.com/watch?v=moRmKo3nrN4
	別のデータベース
	<StartWorkingDirectory>を作成
https://www.youtube.com/watch?v=jgESld7U5Bw
	最後 Peformance Up
		・AsNoTracking
		・eager Loading
		  lazy  Loading
			proxiesをインストール
				useLazyLoadingProxies	DI時にコール
		・Split queries
			asSplitQueryメソッドをコール
		・単独SQLの実行
			FromSqlInterpolatedをコール
		・context pooling
			AddDbContextPoolに変更




2022/11/22 作成開始
一旦アップ

・EntityFrameWorkでOracle19c接続、テーブル、データ作成までを実現する
　ボタン押下で、名前を登録
　初期で一覧を表示
　可能な限り「Clean Architecture」で実装
	サンプルのArchitectureを真似して、Viewでリストボックスに表示する感じ
		FormMainViewerで描画する感じ。
　バージョンも上げること
・Presentationに画面を含むのか？別途用意するのか？
・ModelFirstの初期値作成
・今あるテーブルのModels作成

