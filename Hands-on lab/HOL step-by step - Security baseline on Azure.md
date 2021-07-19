![Microsoft Cloud Workshops](https://github.com/Microsoft/MCW-Template-Cloud-Workshop/raw/main/Media/ms-cloud-workshop.png "Microsoft Cloud Workshops")

<div class="MCWHeader1">
Azure セキュリティ ベースライン
</div>

<div class="MCWHeader2">
ハンズオン ラボ ステップ バイ ステップ
</div>

<div class="MCWHeader3">
July 2021
</div>

# **コンテンツ**
- [**コンテンツ**](#コンテンツ)
- [Azure セキュリティ ベースライン hands-on lab step-by-step](#azure-セキュリティ-ベースライン-hands-on-lab-step-by-step)
  - [学習目標](#学習目標)
  - [概要](#概要)
  - [ソリューション アーキテクチャー](#ソリューション-アーキテクチャー)
  - [必要条件](#必要条件)
  - [Exercise 1: Just-in-Time（JIT）アクセスの導入](#exercise-1-just-in-timejitアクセスの導入)
    - [Task 1: JITによる仮想マシンのセットアップ](#task-1-jitによる仮想マシンのセットアップ)
    - [Task 2: JITリクエストの実行](#task-2-jitリクエストの実行)
  - [Exercise 2: Webアプリケーションとデータベースの保護](#exercise-2-webアプリケーションとデータベースの保護)
    - [Task 1: データベースの設定](#task-1-データベースの設定)
    - [Task 2: Webアプリケーションソリューションのテスト](#task-2-webアプリケーションソリューションのテスト)
    - [Task 3: データマスキングの活用](#task-3-データマスキングの活用)
    - [Task 4: Azure Key Vaultによるカラム暗号化の利用](#task-4-azure-key-vaultによるカラム暗号化の利用)
  - [Exercise 3: Migrating to Azure Key Vault](#exercise-3-migrating-to-azure-key-vault)
    - [Task 1: Azure Key Vaultのシークレットの作成](#task-1-azure-key-vaultのシークレットの作成)
    - [Task 2: Azure Active Directoryアプリケーションの作成](#task-2-azure-active-directoryアプリケーションの作成)
    - [Task 3: Azure Active Directoryのアプリケーション権限の割り当て](#task-3-azure-active-directoryのアプリケーション権限の割り当て)
    - [Task 4: NuGetパッケージのインストールまたは検証](#task-4-nugetパッケージのインストールまたは検証)
    - [Task 5: ソリューションのテスト](#task-5-ソリューションのテスト)
  - [Exercise 4: ネットワークの保護](#exercise-4-ネットワークの保護)
    - [Task 1: ネットワークセキュリティのグループルールのテスト \#1](#task-1-ネットワークセキュリティのグループルールのテスト-1)
    - [Task 2: ネットワークセキュリティグループの設定](#task-2-ネットワークセキュリティグループの設定)
    - [Task 3: ネットワークセキュリティのグループルールのテスト \#2](#task-3-ネットワークセキュリティのグループルールのテスト-2)
    - [Task 4: ネットワークウォッチャーVM拡張機能のインストール](#task-4-ネットワークウォッチャーvm拡張機能のインストール)
    - [Task 5: ネットワークパケットキャプチャの設定](#task-5-ネットワークパケットキャプチャの設定)
    - [Task 6: ポートスキャンの実行](#task-6-ポートスキャンの実行)
  - [Exercise 5: Azure Security Center](#exercise-5-azure-security-center)
    - [Task 1: Linux VMとMicrosoft Monitoring Agent（MMA）のインストール](#task-1-linux-vmとmicrosoft-monitoring-agentmmaのインストール)
    - [Task 2: ブルートフォースアタックの実行](#task-2-ブルートフォースアタックの実行)
    - [Task 3: 変更追跡と更新管理を有効にする](#task-3-変更追跡と更新管理を有効にする)
    - [Task 4: MMA構成の見直し](#task-4-mma構成の見直し)
    - [Task 5: 適応型アプリケーション制御](#task-5-適応型アプリケーション制御)
    - [Task 6: ファイル整合性の監視](#task-6-ファイル整合性の監視)
    - [Task 7: ディスクの暗号化](#task-7-ディスクの暗号化)
  - [Exercise 6: Azure Sentinelのログとレポート](#exercise-6-azure-sentinelのログとレポート)
    - [Task 1: ダッシュボードの作成](#task-1-ダッシュボードの作成)
    - [Task 2: 分析アラートの作成](#task-2-分析アラートの作成)
    - [Task 3: カスタムアラートのインシデントを調査する](#task-3-カスタムアラートのインシデントを調査する)
    - [Task 4: プレイブックの作成と実行](#task-4-プレイブックの作成と実行)
    - [Task 5: Jupyter Notebooksの実行](#task-5-jupyter-notebooksの実行)
    - [Task 6: Power BIでのレポート作成](#task-6-power-biでのレポート作成)
  - [Exercise 7: コンプライアンスツール（Azure Policy、Secure Score、Compliance Manager）の使用について](#exercise-7-コンプライアンスツールazure-policysecure-scorecompliance-managerの使用について)
    - [Task 1: Review a basic Azure Policy](#task-1-review-a-basic-azure-policy)
    - [Task 2: Azure ブループリントの確認と作成](#task-2-azure-ブループリントの確認と作成)
    - [Task 3: セキュア スコア](#task-3-セキュア-スコア)
    - [Task 4: Compliance Manager for Azureの使用](#task-4-compliance-manager-for-azureの使用)
  - [ハンズオンラボの終了後](#ハンズオンラボの終了後)
    - [Task 1: リソースグループの削除](#task-1-リソースグループの削除)
    - [Task 2: Azure Defender Pricingの削除](#task-2-azure-defender-pricingの削除)



# Azure セキュリティ ベースライン hands-on lab step-by-step

## 学習目標

この実習では、Azure Security Center の機能の多くを実装して、クラウドベースの Azure インフラストラクチャ（IaaS）とアプリケーション（PaaS）を保護します。具体的には、インターネットに公開されているリソースが適切に保護されていること、必要のないインターネットアクセスが無効になっていることを確認します。さらに、アプリケーション・セキュリティを有効にしている管理者のために「ジャンプ・マシン」を導入し、管理者が承認されていないソフトウェアをインストールして、クラウド・リソースを公開することを防ぎます。さらに、カスタムアラートを利用してTCP/IPポートスキャンを監視し、アラートを発するようにします。

この実習では、安全なクラウドベースのアーキテクチャを設計・構築したり、Azureでホストされている既存のアプリケーションのセキュリティを向上させたりすることができるようになります。

## 概要

Contosoは、米国に本社を置く多国籍企業で、世界中に保険ソリューションを提供しています。その商品は、傷害保険、健康保険、生命保険、旅行保険、住宅保険、自動車保険などです。Contoso社は、被保険者からの請求に対するデータ収集プロセスの一環として、被保険者に直接モバイルエージェントを派遣して情報を収集するデータ収集サービスを管理しています。これらのモバイルエージェントは、世界中に拠点があり、活動する地域の住民である。モバイルエージェントは遠隔地で管理されており、各地域のコーポレートオフィスには、システムに届いたリクエストに基づいてモバイルエージェントの時間をスケジューリングするサポートスタッフがいます。

同社は、Lift and Shiftを介して多くのアプリケーションをAzureに移行しており、現在行っているのと同じ種類のセキュリティ制御とメカニズムを確実に実装したいと考えています。また、ビジネスを展開している様々な国や地域で要求されるコンプライアンス・ガイドラインを満たす能力があることを証明したいと考えています。すでにWebアプリケーションとデータベースサーバーをAzureインスタンスに移行しており、管理者ログイン、SQLデータベース、仮想ネットワーク設計のための様々なロギングとセキュリティのベストプラクティスを有効にしたいと考えています。

## ソリューション アーキテクチャー

Contoso社の管理者は、最近Azure Security Centerを知り、クラウドベースのAzureインフラストラクチャ（IaaS）とアプリケーション（PaaS）を保護するために、その機能の多くを導入することにしました。具体的には、インターネットに接続されているすべてのリソースのセキュリティを確保し、必要のないインターネットアクセスを無効にすることを目的としています。また、管理者が自分のマシンに承認されていないソフトウェアをインストールして、クラウドのリソースにアクセスしてしまうケースがあったため、アプリケーション・セキュリティを備えた管理者用の「ジャンプ・マシン」の導入も重要だと考えました。さらに、TCP/IPポートスキャンが検出されたときにアラートを出し、その攻撃に基づいて警告を発する機能も必要です。

![This diagram shows external access to Azure resources where Just In Time is utilize to lock down the Jump Machine. Azure Log Analytics with Azure Sentinel is then used to monitor the deny events on the network security groups.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image2.png)

このソリューションでは、まず、ジャンプマシンを作成します。このジャンプマシンは、リソースグループ内の仮想マシンやその他のリソースにアクセスするために使用されます。その他のアクセスは、複数の**仮想ネットワーク**を介して無効にします。1つの**仮想ネットワーク**を使用すると、現在カスタマイズできないデフォルトのセキュリティグループルールに基づいてすべてのリソースにアクセスできるようになるため、複数の仮想ネットワークが必要です。リソースはこれらの仮想ネットワークに編成されます。**Azure Security Center**は、ジャンプマシンへの**Just-In-Time**アクセスを行うために利用されます。これにより、ジャンプマシンへのすべてのアクセスが監査され、許可されたIPアドレスのみがアクセスを許可されていることが保証されます。また、ジャンプマシンにアプリケーションをインストールすることはできませんので、マルウェアが問題になることはありません。それぞれの仮想ネットワークとそれに対応する**ネットワークセキュリティグループ**は、**Azure Logging**に拒否イベントを記録するためにログを有効にしています。これらのイベントは、**Azure Sentinel**の**カスタム アラート ルール**によって監視され、**カスタム アラート**が発せられます。ソリューションが導入されると、**Compliance Manager**ツールが利用され、GDPRに基づいたすべての技術的およびビジネス的なコントロールが実装され、GDPRのコンプライアンスを確保するために維持されます。


## 必要条件

1. Microsoft Azureのサブスクリプションが従量制であること、またはMSDNであること。

    - トライアルサブスクリプションは使えません。

2. 以下のソフトウェアがインストールされたマシン:

    - Visual Studio 2019
    - SQL Management Studio
    - Power BI Desktop

## Exercise 1: Just-in-Time（JIT）アクセスの導入

Duration: 15 minutes

この演習では、Azure Security Center の Just-in-Time アクセス 機能を使用して、Privileged Access Workstation (PAW) ワークステーションを保護します。

### Task 1: JITによる仮想マシンのセットアップ

1. ブラウザで、Azureポータルに移動します。 (<https://portal.azure.com>).

2. **セキュリティ センター** を選択、 **クラウド セキュリティ** の下の、**Just in time VM アクセス** を選択。

    ![Security Center is highlighted on the left side of the Azure portal, and Just in time VM access is highlighted to the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image9.jpg "Security Center VM Access")
    ![Security Center is highlighted on the left side of the Azure portal, and Just in time VM access is highlighted to the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image9-2.jpg "Security Center VM Access")

    ![Security Center is highlighted on the left side of the Azure portal, and Just in time VM access is highlighted to the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image9-3.jpg "Security Center VM Access")

    > **Note**: お客様のサブスクリプションが**Azure Defender オン** に設定されていない可能性があります。その場合、以下のようにしてください。:

   - **セキュリティ センター**ブレードで、**価格と設定**を選択します。
   - ご利用のサブスクリプションを選択します。
   - **Azure Defender オン**を選択します。
   - 有効にするプランを**オン**にします。
   - セキュリティセンターに戻り、**Just in time VM アクセス**を選択します。

3. **構成済み** (Configured) タブを選択し、Lab VMs（db-1、paw-1、web-1）が表示されていることを確認します。 表示されていない場合は、**構成されていません** (Recommended) タブを選択し、ラボVM（db-1、paw-1、web-1）を選択するチェックボックスをオンにして、**Enable JIT on 3 VMs**リンクを選択します。

    ![In the Virtual machines list, the Recommended tab is selected and the db-1, paw-1 and web-1 virtual machines are selected for Just-in-time access.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image9-4.jpg "Virtual Machines Selected")

    > **Note**: Azure Defenderにアップグレードした場合、新しいVMが表示されるまでに最大で10分かかることがあります。 また、バックエンドプロセスによって新しいVMが**サポートなし** (No recommendation) タブに移動するまで、新しいVMが**構成されていません** (Recommended) タブに表示される可能性があることに注意してください。 10分経ってもVMが表示されない場合は、VMブレードの**構成**タブを選択し、**Just-in-Timeを有効にする**ことで、手動でJITを有効にすることができます。

    ![Configuration and Enable JIT Access is highlighted in the Azure portal.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image119.jpg "Enable JIT")

4. 開いた設定画面で、設定内容を確認し、「**保存**」を選択します。

    ![In the configuration window, port settings are listed, and Save is highlighted above them.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image10.png "Select Save")

5. 数分後、仮想マシンが**構成済み**タブに移動しているのが確認できるはずです。

    ![The virtual machines are now on the configured tab.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image11.jpg "The JIT Configured VMs are displayed")

### Task 2: JITリクエストの実行

1. 仮想マシン**paw-1**を選択し、**アクセス権の要求**を選択します。

    ![On the Virtual machines screen, the first listed virtual machine name is selected and highlighted (paw-1), as is Request access button above it.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image12.jpg "Request access for paw-1")

2. 各ポートの**オン**トグルボタンを選択し、デフォルトのIP設定が**自分のIP**になっていることに注意してください。

    ![On is selected under the Toggle column for all four of the ports listed under paw-1.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image13.jpg "Select on for each of the ports")

3. ダイアログの下部で、**ポートを開く**を選択します。しばらくすると、**承認済み**のリクエストが増加し、**最終アクセス日時**が**現在アクティブ**に設定されていることが確認できるはずです。

    ![On the Virtual machines screen, the paw-1 virtual machine displays 1 Request as approved, and the last access column shows Active now.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image14.jpg "View Approved and Last Access status")

    > **Note**:  ARMテンプレートでVMと仮想ネットワークが完全にプロビジョニングされるのを待たなかった場合、エラーが発生する可能性があります。

4. 楕円形を選択し、**アクティビティ ログ**を選択すると、仮想マシンへのアクセスを要求した人の履歴が表示されます。

    ![Activity Log is highlighted in the shortcut menu for the last user.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image15.jpg "View the Activity Log")

    > **Note**: これらのエントリは、VMを削除した後も存続します。VMを削除した後は、手動で削除する必要があります。


5. Azure Portal のメインメニューで、**すべてのサービス**を選択し、**ネットワーク**と入力して、**ネットワークセキュリティグループ**を選択します。

    ![All services is highlighted in the left menu of the Azure portal, and the Network security groups is highlighted in the filtered list to the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image16.jpg "Select paw-1-nsg")

6. フィルターのテキストボックスに**paw-1-nsg**と入力し、**paw-1-nsg**のネットワークセキュリティグループを選択します。

7. **受信セキュリティ規則**を選択すると、JIT アクセスによって設定された受信セキュリティ規則が表示されます。

    ![The first four listed items are highlighted under Inbound security rules.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image17.jpg "View the inbound security rules set up by JIT Access")

## Exercise 2: Webアプリケーションとデータベースの保護

Duration: 45 minutes

この演習では、Azure SQLの機能を利用してデータベースデータをデータマスクし、Azure Key Vaultを利用してデータベースを照会するユーザーやアプリケーションの機密カラムを暗号化します。

### Task 1: データベースの設定

1. Azureポータルに切り替えて、「**すべてのサービス**」を選択し、「**SQL**」を検索します。 **SQL Servers**を選択します。

    ![All services is highlighted on the left side of the Azure portal, and SQL servers is highlighted to the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image18.jpg "Select SQL Servers")

2. Azure Managerテンプレートを使って作成した**Azure SQL**データベースサーバーを選択します（例：AzureSecurity-INIT）。

3. 設定 セクションの **SQL データベース** を選択し、**SampleDB** データベースを選択します。

    ![SQL databases is selected under Settings on the left, and at right, SampleDB is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image19.jpg "Select the SampleDB database")

4. Summaryセクションで、**データベース接続文字列の表示**を選択します。

    ![In the summary section beneath Connection strings the Show database connection strings link is highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image20.jpg "Select the Show database connection strings")

5. このラボで後述する接続文字列、特に**Server**パラメータに注意してください。

    ![The Server parameter is listed under ADO.NET (SQL authentication) on the ADO.NET tab.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image21.png "Note the Server parameter")

6. Lab VM (dsvm-vm) で **SQL Server Management Studio** を開きます。

7. 上記のデータベースサーバー名を入力します。

8. Azure テンプレートのデプロイ時に使用したユーザー名とパスワード（**wsadmin** - **p\@ssword1rocks**）を入力します。

    > **Note**: ARMテンプレートのデプロイ時にユーザー名とパスワードを変更した場合は、その値を代わりに使用してください。

    ![The information above is entered in the Connect to Server dialog box, and Connect is highlighted at the bottom.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image22.jpg "Sign in to the SQL Server Database Engine")

9. Azure SQL 環境への接続方法（VNet 内または外）によっては、ファイアウォールルールを追加するよう促される場合があります。このような場合は、以下の操作を行ってください。

    - Select **Connect**, in the **New Firewall Rule** dialog, select **Sign In**.
    - **Connect**を選択し、**New Firewall Rule**ダイアログで、**Sign in**を選択します。

    - リソースグループオーナーの認証情報を使ってサインインします。

    - ダイアログで、**OK**を選択すると、受信するパブリックIPアドレスが接続用に追加されます。

    ![The New Firewall Rule Dialog is displayed identifying your Internet IP Address.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image23.png "Firewall Rule")

    ※ Firewall Ruleの追加で、エラーが発生する場合は、以下のようにAzureポータルからファイアウォールの設定をしてください。

    ![The New Firewall Rule Dialog is displayed identifying your Internet IP Address.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image23.jpg "Firewall Rule")

10. **Databases**を右クリックし、**Import Data-tier Application**を選択します。

    ![The Object Explorer shows Import Data-tier Application menu item selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image24.jpg "Import Data-tier Application")

11. **Introduction**ダイアログで、**Next**を選択します。

    ![Introduction is highlighted on the left side of the Import Data-tier Application dialog box, and Next is highlighted at the bottom.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image24.png "Select Import Data-tier Application")

12. **Browse**を選択し、解凍した **/Hands-on lab/Database** ディレクトリに移動し、**Insurance.bacpac**ファイルを選択します。

    ![Insurance.bacpac is selected in the Browse dialog box.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image25.png "Select Insurance.bacpac")

13. **Open**を選択します。

14. **Import Settings**ダイアログで、**Next**を選択します。

15. **Database Settings**ダイアログで、**Next**を選択します。

    > **Note**: エラーが発生した場合は、SQL Management Studioを一旦終了し、再度開いてインポートを行ってください。それでもうまくいかない場合は、[こちら](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017)から最新のSQL Management Studioをダウンロードする必要があるかもしれません。最新版では動作しない場合もありますが、バージョン17.3ではパッケージが正しく展開されることが知られています。 また、一部のSQL Serverインスタンスからエクスポートされたbacpacファイルは、Azure SQL Serverにデプロイできないことにも注意が必要です。 また、Insuranceデータベースの.bakファイルを同梱していますので、復元にご利用ください。

16. **Finish**を選択すると、データベースがAzureにデプロイされます。数分かかる場合があります。

17. 完了したら、**Close**を選択します。

    ![Results is highlighted on the left side of the Import Data-tier Application dialog box, and at right, many items are listed under Operation Complete. Next is highlighted at the bottom.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image26.png "View the results")

18. **SQL Management Studio**で、「File」-「Open」-「File」を選択します。

    ![In SQL Management Studio, Open is selected in the File menu, and File is selected in the shortcut menu.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image27.png "Open a file")

19. 解凍した GitHub フォルダを参照し、**\Hands-on lab\Database\00_CreateLogin.sql**ファイルを選択します。

20. **master**データベースが選択されていることを確認します。

21. スクリプトを実行して、**agent**という名前のログインを作成します。

22. 解凍したフォルダを参照し、**\Hands-on lab\Database\01_CreateUser.sql** ファイルを選択してください。

23. **Insurance**データベースが選択されていることを確認します。

24. スクリプトを実行して、**agent**という非管理者ユーザーを作成します。

### Task 2: Webアプリケーションソリューションのテスト

1. 解凍したディレクトリの中にある**Hands-on lab\WebApp\InsuranceAPI**というソリューションファイルをダブルクリックすると、Visual Studioが立ち上がります。

    > **Note**: プロンプトが表示されたら、Azure / MSDNアカウントでログインしてください。

2. **ソリューション エクスプローラー**で、**Web.config**ファイルをダブルクリックして開きます。

    ![Web.config is highlighted under the InsuranceAPI project in Solution Explorer.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image28.jpg "Open Web.config")

3. Task 2 で作成した **Insurance** データベースを指すように web.config を更新します（77 行目）。サーバー名を更新して、Azure SQL Serverを指すようにするだけでよいでしょう。

    ![Line 72 of the Insurance database is highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image29.png "Update the server name in Web.config")

4. **F5**を押して、**InsuranceAPI**ソリューションを実行します。

    > **Note**: CSCエラーが発生した場合は、プロジェクトを右クリックして **CLEAN**を選択します。 次に、プロジェクトを右クリックして**再構築**を選択します。

5. `http://localhost:24448/api/Users` にアクセスして、APIの応答をテストします。ポート番号は_24448_と異なるかもしれません。ブラウザにいくつかのレコードが返されるのが見えるはずです。次の命令のために `UserId` の値をコピーしてください。

    ![The sample JSON response is returned.](media/2019-12-18-16-59-47.png "Sample JSON Response")

6. 開いたブラウザウィンドウで、`http://localhost:24448/api/Users/e91019da-26c8-b201-1385-0011f6c365e9`をブラウズすると、マスクされていないSSNカラムを示すjsonレスポンスが表示されます。

    > **Note**: お使いのブラウザによっては、json形式のレスポンスを表示するためにダウンロードが必要な場合があります。

   ![The json response is displayed in a browser window.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image30.png "View the json response")

### Task 3: データマスキングの活用

1. Azure Portal に切り替えます。

2. **SQL データベース**を選択します。

3. **Insurance**データベースを選択します。

4. **セキュリティ**の項目で、**動的データマスキング**を選択し、**+ マスクの追加**を選択します。

    ![Dynamic Data Masking is highlighted on the left, and +Add mask is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image31.jpg "Select +Add mask")

5. **User**テーブルを選択します。

6. **SSN**列を選択します。

7. **追加**を選択します。

    ![Add is highlighted at the top of the SSN column, and the User table and SSN column are highlighted below.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image32.jpg "Select Add")

8. **保存**を選択し、**OK**を選択します。

9. InsuranceAPIソリューションに戻り、**F5**を押してページを更新します。SSNカラムが**xxxx**でマスクされていることが確認できます。

    ![The masked SSN column is highlighted in the InsuranceAPI response.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image33.png "View the masked SSN column")

10.  **Visual Studio** を閉じます。

### Task 4: Azure Key Vaultによるカラム暗号化の利用

1. **SQL Management Studio**に切り替えます。

2. **File->Open->File**を選択し、**02\_PermissionSetup.sql**ファイルを開きます。

3. **Insurance**データベースに切り替え、SQL文を実行します。

4. **Object Explorer**で、**Insurance**ノードを展開します。

5. **Tables**ノードを展開します。

6. **User** テーブルノードを展開します。

7. **Columns**ノードを展開します。

8. **SSN**列を右クリックし、**Encrypt Column**を選択します。

    ![Tables and dbo.User are highlighted in the Insurance database tree. Below that, the SSN column is selected and highlighted, and Encrypt Column is highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image34.png "Select Encrypt Column")

    列の状態は、暗号化（データマスキング）を加えることができないようになっていることに注意してください。

    ![A slashed circle appears in the State column.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image35.png "View data masking")

9. **Cancel**を選択します。

10. Azure ポータルに戻り、User_SSN データマスキングを選択します。

11. **削除** を選択します。

    ![The Delete icon is highlighted under Edit Masking Rule in the Azure portal.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image36.jpg "Select Delete")

12. **保存**を選択します。

13. **SQL Management Studio**に戻ります。

14. **SSN**列を右クリックし、**Encrypt Column**を選択します。

15. **SSN**欄の横のチェックボックスにチェックを入れます。

16. **Encryption Type**で**Deterministic**を選択します。

    ![The check box next to the SSN column is selected and highlighted, and Deterministic is highlighted under Encryption Type.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image37.png "Select Deterministic")

    > **Deterministic** 暗号化は、与えられた平文の値に対して常に同じ暗号化された値を生成します。決定論的な暗号化を使用すると、暗号化されたカラムに対するポイントルックアップ、等号結合、グループ化、インデックス化が可能になります。しかし、特にTrue/FalseやNorth/South/East/Westのように暗号化された値のセットが少ない場合には、暗号化されたカラムのパターンを調べることで、権限のないユーザーが暗号化された値の情報を推測することができてしまいます。決定論的暗号化では、文字列の照合順序を binary2 にする必要があります。

    > **Randomized** 暗号化は、予測不可能な方法でデータを暗号化する方法を採用しています。ランダムな暗号化はより安全ですが、暗号化されたカラムでの検索、グループ化、インデックス化、結合ができなくなります。

17. **Next**を選択します。

18. 暗号化には、ダイアログで **Azure Key Vault** を選択します。

    ![Azure Key Vault is selected in the Select the key store provider section.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image38.png "Select Azure Key Vault")

19. **Sign In**を選択します。

20. Azureポータルの認証情報を使ってサインインします。

21. Azure Key Vault を選択します。

22. **Next**を選択します。

23. **Run Settings**で**Next**を選択します。

24. **Finish**を選択すると、設定が開始されます。

    > **Note**: **Wrap Key**エラーが発生する場合があります。その場合は、Azure Key Vaultでアカウントに**wrapKey**権限が割り当てられていることを確認してください。

    ![Generate new column master key CMK\_Auto1 in Azure Key Vault is highlighted with a green check mark at the top of the Task Summary list.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image39.png "View the task summary")

    - **Key vault**を選択します。

    - 自分のKey Vaultを選択してください。

    - **Access policies**を選択します。

    - **Add New**を選択します。

    - プリンシパルの場合は、アカウントを選択します。

    - **Key permissions**を選択し、**Select all**を選択します。

        ![Select all is selected and highlighted under Key permissions, and below that, Decrypt, Encrypt, Unwrap Key, Wrap Key, Verify, and Sign are selected and highlighted under Cryptographic Operations amid the other selected options.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image40.png "Select all")

    - **Secret permissions**を選択し、**Select all**を選択します。

    - **Certificate permissions**を選択し、**Select all**を選択します。

    - **OK**を選択します。

    - **Save**を選択します。

    - 操作をやり直します。

    > **Note**: それでもエラー（Access Deniedなど）が発生する場合は、正しいサブスクリプションとKey Vaultを選択しているか確認してください。


    ![Results is highlighted on the left side of the Always Encrypted dialog box, and at right, Performing encryption operations is selected under Summary: Task. Performing encryption operations has a green check mark and is listed as Passed under Details.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image41.png "View the task results")

25. **Close**を選択します。

26. **Users**テーブルを右クリックし、**Select top 1000 rows** を選択します。

    ![The User table is selected, and Select Top 1000 Rows is selected in the shortcut menu.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image42.png "Select the top 1000 rows")

    You will notice the SSN column is encrypted based on the new Azure Key Vault key.

    ![The value under UserId is selected on the Results tab.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image43.png "Notice the SSN column")

27. Azureポータルに切り替えます。

28. **Key Vaults**を選択します。

29. Azure Key Vault を選択して、「**Keys**」を選択します。SQL Management Studioから作成されたキーが表示されるはずです。

    ![CloudSecurityVault is selected on the left, Keys is selected under Settings from the center menu, and CMKAuto1 is selected under the Unmanaged list on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image44.png "Select your Azure Key Vault")

## Exercise 3: Migrating to Azure Key Vault

Duration: 30 minutes

この演習では、アプリケーションの構成ファイルに貴重な認証情報（接続文字列など）を保存するのではなく、Azure Key Vaultを利用するようにWebアプリケーションを移行する方法を学びます。

### Task 1: Azure Key Vaultのシークレットの作成

1. 自分のAzureポータルに切り替えます。

2. **キーコンテナー**を選択し、Azure Key Vaultを選択します。

    ![Key vaults is highlighted on the left side of the Azure portal, and CloudSecurityVault is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image45.jpg "Select your Azure Key Vault")
    ![Key vaults is highlighted on the left side of the Azure portal, and CloudSecurityVault is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image45-2.jpg "Select your Azure Key Vault")

3. **シークレット**を選択し、**+ 生成/インポート**を選択します。

    ![Secrets is highlighted on the left side of the Azure portal, and Generate/Import is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image45-3.jpg "Create a new secret")

4. **アップロードオプション**で、 **手動**.を選択します。

5. **名前**には、**InsuranceAPI**と入力します。

6. **値**には、Exercise 2の**InsuranceAPI**ソリューションのWeb.configファイルから接続文字列情報をコピーします。

7. **作成**を選択します。

8. **シークレット**を選択します。

9. **InsuranceAPI**を選択します。

10. 現在のバージョンを選択します。

    ![The current version is selected with a status of Enabled under InsuranceAPI Versions.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image46.jpg "Select the current version")

11. 後で使用するために、シークレット識別子のURLをコピーして記録します。

    ![The Secret Identifier URL is highlighted under Properties.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image47.jpg "Copy and record the secret identifier URL")

### Task 2: Azure Active Directoryアプリケーションの作成

1. Azure Portalで、**Azure Active Directory**を選択し、**アプリの登録**を選択します。

    ![Azure Active Directory is highlighted on the left side of the Azure portal, and App registrations is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image48-1.jpg "Select App registrations")
    ![Azure Active Directory is highlighted on the left side of the Azure portal, and App registrations is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image48-2.jpg "Select App registrations")

2. **+ 新規登録** を選択します。

3. For the user-facing display name, type **AzureKeyVaultTest**.

4. 対応しているアカウントについては、**この組織ディレクトリ内のみに含まれるアカウント...**を選択します。

5. For the Redirect URL, type <http://localhost:12345>.

    ![AzureKeyVaultTest is entered in the Name box, and http://localhost:12345 is entered in the Sign-on URL box under Create.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image49.jpg "Create a new application registration")

6. **登録**を選択します。

7. **アプリケーションID**をコピーして記録します。

    ![The Application ID and Object ID are highlighted under Essentials for the AzureKeyVaultTest application, and All settings is selected at the bottom.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image50.jpg "Copy and record the Application ID and Object ID")

8. 左側のメニューペインの**管理**の見出しの下で、**証明書とシークレット**リンクを選択します。

9. **クライアントシークレット**の下の **新しいクライアントシークレット**を選択します。

    ![In the Certificates and secrets window, the New client secret button is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image50-2.jpg "New Client Secret")

10. 説明には **InsuranceAPI** と入力します。

11. Expiresは**12ヶ月**を選択。

12. **追加**を選択します。

13. キーの値をコピーして記録し、後で使用できるようにします。

### Task 3: Azure Active Directoryのアプリケーション権限の割り当て

1. Azure Portal に戻って、Azure Key Vault を選択します。

2. **設定**の項目で **アクセス ポリシー**を選択します。

3. **+ アクセス ポリシーの追加**を選択します。

    ![In the Access policies screen, the + Add Access Policy button is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image51.jpg "Add a new access policy")

4. **プリンシパルの選択**フィールドの値を選択します。右側のペインで、**AzureKeyVaultTest** と入力します。項目を選択します。

5. 下部にある**選択**ボタンを選択します。

6. **シークレットのアクセス許可**のドロップダウンを選択し、**取得**と**一覧**のパーミッションをチェックします。

    ![In the secret permissions drop down options, the Get and List operations are selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image52-0.jpg "Configure Select principal settings")

    選択肢は以下のようになります。

    ![The AzureKeyVaultTest principal is selected and the secret permissions drop down list states there are two selected values.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image52.jpg "Configure Select principal settings")

7. **追加**ボタンを選択します。

8. 上部の**保存**ボタンを選択します。

### Task 4: NuGetパッケージのインストールまたは検証

1. 先ほどの Visual Studio ソリューションを終了し、解凍した GitHub ディレクトリから、 **\Hands-on lab\WebApp\InsuranceAPI\_KeyVault\InsuranceAPI.sln** ソリューションを開きます。

    >**Note**:  必ず正しいソリューションを開き直してください。

    ![The screenshot displays the folder structure for both Visual Studio solutions.](media/2019-12-19-13-13-07.png "Both InsuranceAPI Solutions")

2. **Visual Studio**に切り替えます。

3. メニューの中の、**表示-\>その他のウインドウ-\>パッケージ マネージャー コンソール**を選択します。

4. 開いた新しいウィンドウで、以下のコマンドを実行します。

    ```PowerShell
    Install-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform
    ```

    ```PowerShell
    Install-Package Microsoft.IdentityModel.Clients.ActiveDirectory -Version 2.16.204221202
    ```

    ```PowerShell
    Install-Package Microsoft.Azure.KeyVault
    ```

    > **Note**: これらはすでにプロジェクト内に存在していますが、参照用として提供されています。デバッグ時にcodedomバージョンエラーが発生する場合は、このコマンドを実行してください。

    ```PowerShell
    Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
    ```

5. **ソリューションエクスプローラー**から、**Web.config**ファイルをダブルクリックして開きます。

    **appSettings**セクションには、いくつかのトークン値があることに注目してください。

    ![Some token values are highlighted in the appSettings section of the Web.config file.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image53.png "Note the token values")

6. **ApplicationID**(**ClientID**)と**ClientSecret**をTask 2の値に置き換えてください。

    ![The pane is displaying the Application Registration information. ApplicationId is circled.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image54-0.jpg "Applicaiton Registration")

7. **SecretUri**をTask 1のAzure Key VaultのシークレットキーUriに置き換えます。

8. Visual StudioでWeb.configファイルを保存します。

    > **Note**:  このラボを一歩進めて、Web App を Azure App Service に公開し、[システム割り当て マネージドID](https://docs.microsoft.com/ja-jp/azure/app-service/overview-managed-identity?tabs=dotnet)を有効にすることができます。  これにより、設定から認証を完全に取り除き、[Key Vault 参照](https://docs.microsoft.com/ja-jp/azure/app-service/app-service-key-vault-references)を利用することができます。

### Task 5: ソリューションのテスト

1. **Web.config**を開き、78行目の**connectionString**をコメントアウトまたは削除します。

2. **Global.asax.cs** ファイルを開き、28行目にブレークポイントを置きます。

    > **Note**: このコードでは、上記で設定したアプリケーションのアクセストークンを取得するための呼び出しを行い、そのアクセストークンを使ってAzure Key Vaultを呼び出しています。

3. **F5**を押して、ソリューションを実行します。

    Azure Key Vaultへの呼び出しが実行され、シークレット（ここではAzure Databaseへの接続文字列）が返されているのがわかるはずです。

    ![The connection string to the Azure Database is visible through the Visual Studio debugger.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image54.png "View the connection string")

4. **F5**を押して、プログラムを続行します。

5. [http://localhost:portno/api/Users](http://localhost:portno/api/Users) にナビゲートすると、エラーが表示されるはずです。前の演習で列を暗号化したため、EntityFrameworkはデフォルトの設定を使用して値（複数可）を取得することができません。シームレスな復号化を行うためには、以下のことが必要です。
    - まだ実行していない場合は、**\\Hands-on lab\\Database\\02\_PermissionSetup.sql**スクリプトを実行してください。

    - プロジェクトに[AzureKeyVaultProvider for Entity Framework](https://blogs.msdn.microsoft.com/sqlsecurity/2015/11/10/using-the-azure-key-vault-key-store-provider-for-always-encrypted/)の参照を追加します。

    - .NETで暗号化されたカラムを処理するために、プロバイダコードを登録します。
  
    - Azure Key Vault に、Azure AD アプリケーションにキーのパーミッション（`decrypt`、`sign`、`get`、`unwrapkey`、`verify`）を与えるアクセスポリシーを追加します。

    - 接続文字列に`Column Encryption Setting=Enabled`を追加します。

    - 詳しい手順はこちらの[ブログ記事](https://docs.microsoft.com/en-us/archive/blogs/sqlsecurity/using-the-azure-key-vault-key-store-provider-for-always-encrypted)をご覧ください。

    - 3つ目のソリューション（**\\Hands-on lab\\WebApp\\InsuranceAPI\_KeyVault\_Encrypted\\InsuranceAPI.sln**）は、GitHub repoに必要なリファレンスとコードが追加されています。 

  
      - 上記の Key Vault パーミッションを追加した後、クライアント ID とシークレットで web.config ファイルを更新してください。
  
      - Key Vaultの接続文字列を更新して、`Column Encryption Setting=Enabled`とします。

      - global.asax.csファイルに追加されたコードを確認します。

      - プロジェクトを実行し、上記のページに移動します。

## Exercise 4: ネットワークの保護

Duration: 45 minutes

この演習では、ネットワークセキュリティグループを利用して、仮想マシンが他のAzureホストサービスから分離されていることを確認した後、Azureのネットワークパケットキャプチャ機能を使用して、ネットワーク間のトラフィックを積極的に監視します。

### Task 1: ネットワークセキュリティのグループルールのテスト \#1

1. Azureポータルで、**Virtual Machines**を選択します。

2. **paw-1**を選択し、**接続**を選択します。 

3. ダイアログが表示されますので、「**Download RDP file Anyway**」を選択します。 ダウンロードしたRDPファイルを開き、仮想マシンに接続します。

    > **Note**: デフォルトのユーザー名は **wsadmin** 、パスワードは **p\@ssword1rocks** です。演習の合間に休憩を取った場合は、JITアクセスを要求する必要があります。

4. **paw-1**の仮想マシンで、**administrator**として**Windows PowerShell ISE**を開きます。

    - **Windows**のアイコンを選択します。

    - **Windows PowerShell ISE**を右クリックし、**More**を選択し、**Run as Administrator**を選択します。

5. 以下のコマンドをコピーして実行します。

    ```PowerShell
    Set-ExecutionPolicy -ExecutionPolicy Unrestricted
    ```

    ![The PowerShell ISE window displays the execution policy change command.](media/2020-01-12-12-39-24.png "PowerShell")

6. ダイアログでは、**Yes**を選択します。

7. **File->Open**を選択し、解凍したGitHubのディレクトリを参照して、**\Hands-on lab\Scripts\PortScanner.ps1**を開きます。

    > **Note**: 事前準備で、[GitHub repo](https://github.com/Microsoft/MCW-Azure-Security-Privacy-and-Compliance)をダウンロードして、セットアップの手順でこれを展開したと思います。 これらの手順を実行していない場合は、今すぐ実行してください。また、デスクトップからVMにファイルをコピーすることもできます。

8. スクリプトを確認します。このスクリプトでは、様々な練習問題に対して以下のことが行われていることに注目してください。

   - Putty をインストールします。

   - NotePad++ をインストールします。

   - DNS用のHostsエントリーを追加

   > **Note**: 複数の仮想ネットワークを使用する場合は、Azure テナントに DNS サーバーを設定する必要があります。

   - ポートスキャンの実行

   - ブルートフォースSSH攻撃の実行

9. **F5**を押して Exercise 4のスクリプトを実行します。以下のように表示されるはずです。

    > **Note**:  ARMテンプレートでは、Deny Allルールを展開します。 単にUIからネットワークセキュリティグループを作成しただけでは、このような動作は発生しません。

    - **paw-1**マシンから**db-1**および**web-1**への3389番ポート(RDP)のポートスキャンが失敗しました。

    - 上記のポート3389（RDP）の情報は、スクリプトを実行して**F5**を押すと表示されます。

    ![The information above for port 3389 (RDP) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image55.png)

    - **paw-1**マシンから**db-1**および**web-1**へのポート1433（SQL）のポートスキャンが失敗しました。**db-1**はSQL Serverを実行していますが、トラフィックはNSGおよびWindowsファイアウォール経由でデフォルトでブロックされています。しかし、ARMテンプレート内でdb-1サーバの1433ポートを開くスクリプトが実行されました。

    ![The information above for port 1433 (SQL) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image56.png "View the information")

    - **paw-1**マシンから**db-1**および**web-1**への80番ポート（HTTP）のポートスキャンが失敗しています。トラフィックが許可されている場合、**db-1**にはIISやその他のWebサーバーが稼動していないため、常に失敗します。

    ![The information above for port 80 (HTTP) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image57.png)

### Task 2: ネットワークセキュリティグループの設定

1. [Azure ポータル](https://portal.azure.com)に切り替えます。

2. WebサーバーからのSQL接続のみを許可するようにデータベースサーバーを設定します。

   - **ネットワーク セキュリティ グループ** を選択します。

   - **DbTrafficOnly** を選択します。

   - **受信セキュリティ規則** を選択します。

   - **+ 追加** を選択します。

   - **ソース** に **IP Addresses** を選択します。

   - **ソース IP アドレス**に **10.2.0.4** を入力します。
  
   - **宛先** を **Any** のままにします。

   - **宛先ポート範囲** に **1433** を入力します。

   - **優先度** に **100** を入力します。

   - **名前** に **Port_1433** を入力します。

   - **追加** を選択します。

   - **+ 追加** を選択します。

   - **ソース** に **IP Addresses** を選択します。

   - **ソース IP アドレス** に **10.0.0.5** を入力します。
  
   - **宛先** を **Any** のままにします。

   - **宛先ポート範囲** に **1433** を入力します。

   - **優先度** に **102** を入力します。

   - **名前** に **Port_1433_Paw** を入力します。

   - **追加** を選択します。

3. すべてのHTTPおよびHTTPS接続を許可するようにWebサーバーを設定する。

   - **ネットワーク セキュリティ グループ** を選択します。

   - **WebTrafficOnly** を選択します。

   - **受信セキュリティ規則** を選択します。

   - **+ 追加** を選択します。

   - **ソース** を **Any** のままにします。

   - **宛先** を **Any** のままにします。

   - **宛先ポート範囲** に **80,443** を入力します。

   - **優先度** に **100** を入力します。

   - **名前** を **Port\_80\_443** に変更します。

   - **追加** を選択します。

   > **Note**: まれに、ネットワークセキュリティグループのステータスが**更新中**から変更されるまでに15分程度かかる場合があります。 この変更が完了するまで、他のルールを追加することはできません。

4. データベースとWebサーバーの両方で、PAWマシンからのRDP接続のみを許可するように設定します。

    - **ネットワーク セキュリティ グループ**を選択します。**DbTrafficOnly** と **WebTrafficOnly** の両方について、以下の操作を行います。

       - **受信セキュリティ規則** を選択します。

       - **+ 追加** を選択します。

       - **ソース** に **IP Addresses** を選択します。

       - **ソース IP アドレス** に **10.0.0.5** を入力します。

       - **宛先ポート範囲** に **3389** を入力します。

       - **優先度** に **101** を入力します。

       - **名前** に **Port_3389** を入力します。

       - **追加** を選択します。

5. すべてのネットワークセキュリティグループの診断ログを有効にする。

    - **ネットワーク セキュリティ グループ** を選択します。 各NSG（DBTrafficOnly、WebTrafficOnly）について、以下を行います。

       - コンテンツメニューで**診断設定** を選択し、**+ 診断設定を追加する** を選択します。

        ![Diagnostics settings is selected under Monitoring on the left side, and Add diagnostics settings is selected on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image58.jpg "Add diagnostic settings")

      - 名前にはNSGの名前を入力し、最後に**Logging**を付けます。

      - **Log Analytics ワークスペースへの送信** チェックボックスをチェックし、**Log Analytics**ボックスで、**Configure**を選択します。

      - ワークスペースの**azseclog...**を選択します。

      - LOGのチェックボックスを両方とも選択します。

      - **保存** を選択します。

       ![Save is highlighted at the top, and two log items are selected below.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image60.jpg "Save the logs")

### Task 3: ネットワークセキュリティのグループルールのテスト \#2

1. **paw-1**の仮想マシンに切り替えます。

2. **F5** を押して、**PortScan**スクリプトを実行します。以下のように表示されるはずです。

    - **paw-1**マシンから**db-1**および**web-1**への3389番ポート（RDP）のポートスキャンに成功しました。

    ![The information above for port 3389 (RDP) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image61.png "View the information")

    - paw-1**マシンから**db-1**への1433番ポート（SQL）のポートスキャンは成功し、**web-1**は失敗しています。

    > **Note**: ARMスクリプトが失敗した場合、この結果を得るためには、db-1サーバーのWindowsファイアウォールを無効にする必要があるかもしれません。

    ![The information above for port 1433 (SQL) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image62.png "View the information")

    - **Note**: ARMテンプレートは、web-1にIISをインストールしました。**paw-1**マシンから**web-1**への80番ポート（HTTP）のポートスキャンは成功しましたが、**db-1**にはIISが動作していないため失敗しました。

    ![The information above for port 80 (HTTP) is visible after running the script and pressing F5.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image63.png "View the information")

### Task 4: ネットワークウォッチャーVM拡張機能のインストール

1. Azureポータルに切り替えます。

2. **Virtual Machines** を選択します。

3. **db-1** を選択します。

4. ブレードメニューで **拡張機能** を選択し、 **+ 追加** を選択します。

    ![Extensions is selected on the left under Settings, and + Add is highlighted at the top right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image64.jpg "Select + Add")

5. **Network Watcher Agent for Windows** を参照し、選択します。

6. **次へ** を選択します。 **確認と作成** を選択します。 **作成** を選択します。

    ![Network Watcher Agent for Windows is highlighted on the left, and Create is highlighted on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image65.jpg "Create a Network Watcher agent")

7. 次の**拡張機能のインストール** ダイアログウィンドウ（空白の場合もあります）で**OK** を選択します。仮想マシンにスクリプト拡張がインストールされたことを通知するダイアログトーストが表示されます。

    ![The toast notification states: "Deployment in progress ... Deployment to resource group 'azure-securitytest1' is in progress."](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image66.png "Toast notification about the script installation")

### Task 5: ネットワークパケットキャプチャの設定

1. Azureポータルのメインメニューで、**すべてのサービス**から**Network Watcher**を検索します。

2. コンテキストメニューで**Network Watcher**を選択します。

    ![Network watcher is selected from the filtered list of services.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image66-2.jpg "Network watcher search result")

3. **+ 追加** ボタンを選択します。 ラボを実行しているサブスクリプション地域の項目を展開します。

4. **東日本** リージョン（またはVMをデプロイしたリージョン）では、省略記号を選択し、「**Enable network watcher**」を選択します。

    ![The East US row is highlighted under Region, and Enable network watcher is selected in the submenu.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image66-3.jpg "Enable Network Watcher")

5. 新しいコンテキストメニューで、**パケットキャプチャ** を選択します。

6. **+ 追加** を選択します。

    ![Packet capture is selected and highlighted on the left under Network Diagnostic Tools, and + Add is highlighted at the top right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image69.jpg "Add a packet capture")

7. サブスクリプションを選択します。

8. リソースグループを選択します。

9.  対象となる仮想マシンに **db-1** が選択されていることを確認します。

10. キャプチャー名には **databasetraffic** と入力します。

11. キャプチャーファイルをローカルマシンまたはAzureストレージアカウントに保存できることに注目してください。リソースグループのストレージアカウントが選択されていることを確認します。 リソースグループを確認すると、ストレージアカウントの先頭に **"diagstor "** が付いています。

12. 値は以下のように入力します。

    - 1 パケットあたりの最大バイト数: 0.
    - 1 セッションあたりの最大バイト数: 1073741824.
    - 制限時間: 600.

    ![In the Add packet capture window, databasetraffic is entered in the Packet capture name box, and the Storage account check box is checked.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image69-2.jpg "Dialog box screenshot")

13. **保存** を選択します。

### Task 6: ポートスキャンの実行

1. リモートデスクトップの接続先を、**paw-1**仮想マシンに切り替えます。

2. スクリプトの次の行をアンコメントして、**F5**を押します。

    ```PowerShell
    #TestPortRange $computers 80 443;
    ```

   ![The PowerShell ISE window displays uncommented PowerShell script port scan command.](media/2020-01-12-12-49-13.png "Running the uncommented PowerShell script")

    > **Note**: 基本的なポートがスキャンされ、次に80から443までのポートスキャンが行われるはずです。これにより、ネットワークセキュリティグループのセキュリティセンターログが多数生成され、次の演習課題のカスタムアラートで使用されます。スクリプトが実行されている間、次の演習に進みます。

## Exercise 5: Azure Security Center

Duration: 45 minutes

Azure Security Centerは、デフォルトでは有効になっていないいくつかの高度なセキュリティおよび脅威検出機能を提供します。この演習では、そのうちのいくつかを調べて有効にします。

### Task 1: Linux VMとMicrosoft Monitoring Agent（MMA）のインストール

1. Azure Portalで、**azsecurity-INIT** リソースグループを参照して、*azseclog...* **Log Analytics Workspace**を選択します。

    ![The log analytics workspace is highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/LogAnalyticsWorkspace.jpg "Select the log analytics workspace")

2. ブレードで **エージェント管理** を選択します。

3. 後で利用するため、**ワークスペースID** と **主キー** の値を記録します。

   ![Agents management blade link is highlighted along with the id and key for the workspace](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/LogAnalyticsWorkspace_Settings.jpg "Copy the workspace id and key")

4. リモートデスクトップ接続で**paw-1**に切り替えます。

5. **Putty**ツールを開き、ユーザー名とパスワードを使って **linux-1** マシンにログインします。
(###名前解決できているか確認)

   ![Putty window with linux-1 as the host.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/putty-linux-1.png "Use Putty to login to linux-1")

6. Run the following commands, be sure to replace the workspace tokens with the values you records above:

    ```bash
    wget https://raw.githubusercontent.com/Microsoft/OMS-Agent-for-Linux/master/installer/scripts/onboard_agent.sh && sh onboard_agent.sh -w <YOUR_WORKSPACE_ID> -s <YOUR_WORKSPACE_KEY>

    sudo /opt/microsoft/omsagent/bin/service_control restart <YOUR_WORKSPACE_ID>

    ```

7. Switch back to the Azure Portal.

8. In the blade menu, select **エージェント管理** and then select **Linux  サーバー** タブ, you should see **1 台の Linux コンピューターが接続されています**.

   ![The displayed of connected linux computers for the workspace.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/loganalytics-linux-computers.jpg "Review the linux computers connected to workspace")

   > **Note**: ほとんどの場合、Azureはリソースグループのログ分析ワークスペースにリソースを自動的に割り当てます。

### Task 2: ブルートフォースアタックの実行

1. リモートデスクトップ接続で、**paw-1**に切り替えます。

2. PowerShell ISEで、Exercise 4の行をコメントし、Exercise 5の行をアンコメントします。

3. スクリプトを実行すると、puttyからplinkツールを使って**linux-1**マシンにSSHでログインしようとする試みが何度か実行されることに注目してください。

4. しばらくすると（最大30分）、ブルートフォース攻撃が成功したことを示すSecurity Centerのアラートが表示されます。

    ![The email warning about the Brute Force Attack.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/linux-brute-attack-warning.png "The Azure Security Center warning about brute force attack")


### Task 3: 変更追跡と更新管理を有効にする

1. Azureポータルに戻します。

2. 検索メニューで **Virtual Machine** と入力し、選択します。

3. デプロイされた**paw-1**、**web-1**、**db-1**、**linux-1**の仮想マシンをハイライト表示します。

4. トップメニューで「**サービス**」を選択し、「**Change Tracking**」を選択します。

   ![The virtual machines are selected and the change tracking menu item is selected.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/virtual-machines-svcs-changetracking.jpg "Enable change tracking for the virtual machines")

5. **カスタム** のラジオボタンを選択します。

6. **変更**を選択し、ラボのARMテンプレートで展開された**Log Analytics ワークスペース**を選択します。

    ![The change tracking blade is displayed with custom and change link highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/virtual-machines-svcs-changetracking-config.jpg "Select CUSTOM and then select change links")

7. リソースグループのログアナリティクスワークスペースを選択し、一致するオートメーションアカウントを選択して、「**OK**」を選択します。

    ![The custom configuration dialog is displayed with the log analytics workspace select along with the matching automation account.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/virtual-machines-svcs-changetracking-config2.png "Select the resource group log analytics workspace and matching automation account")

8. すべての仮想マシンを選択し、「**有効化**」を選択します。

    ※サブスクリプションが出てこない場合、各仮想マシンで変更履歴を有効化する。
    ![The custom configuration dialog is displayed with the log analytics workspace select along with the matching automation account.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/virtual-machines-svcs-changetracking-config2.jpg "Select the resource group log analytics workspace and matching automation account")


9. **Virtual Machines**ブレードに戻り、デプロイされた**paw-1**、**web-1**、**db-1**、**linux-1**の仮想マシンを再度ハイライトします。

10. トップメニューで「**サービス**」を選択し、「**インベントリ**」を選択します。

11. **カスタム** ラジオボタンを選択します。

12. **変更**を選択し、ラボのARMテンプレートで展開された**Log Analytics ワークスペース**を選択します。

13. 最後のタスクに基づいて、すべてのVMがすでにワークスペースに対して有効になっていることに注目してください。

14. **Virtual Machines**ブレードに戻り、デプロイされた**paw-1**、**web-1**、**db-1**、**linux-1**の仮想マシンをハイライト表示します。

15. トップメニューから「**サービス**」を選択し、「**Update Management**」を選択します。

16. **Customer**のラジオボタンを選択します。

17. **変更**を選択し、ラボのARMテンプレートで展開された**Log Analytics ワークスペース**を選択します。

18. すべての仮想マシンを選択して、**有効化**を選択します。

19. リソースグループを参照して、Log Analyticsワークスペースを選択します。

20. **概要**セクションで、**ソリューション**ブレードを選択すると、**ChangeTracking**と**Updates**ソリューションがワークスペースに追加されていることがわかります。**ChangeTracking**ソリューションを選択します。

    ![The solutions configured for the workspace are displayed.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/loganalytics-solutions.jpg "Select the ChangeTracking solution item")

21. **Workspace Data Sources** セクションで **ソリューションのターゲット設定(プレビュー)** を選択します。

22. 項目の右側の楕円からスコープを削除します。

    ![The solutions configured for the workspace are displayed.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/loganalytics-solutions2.jpg "Select the ChangeTracking solution item")

23. この手順を繰り返して、「**Updates**」ソリューションの対象となるソリューションを削除します。

### Task 4: MMA構成の見直し

1. リモートデスクトップ接続で、**paw-1**に切り替えます。

2. **Event Viewer** を開きます。

3. **Applications and Services Logs**を展開して、**Operations Manager**を選択します。

4. **Operation Manager** を右クリックし、**Filter Current Logs** を選択します。

    ![The event viewer is displayed with the click path highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/eventviewer-operations-mgr.png "Filter the Operations Manager event logs")

5. イベントIDに「**5001**」と入力し、最新のエントリを選択すると、先ほど追加したものを含め、Log Analyticsワークスペースに展開されているすべてのソリューションに似た名前が表示されます。

    ![The event viewer is displayed with the click path highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/eventviewer-operations-mgr-5000.png "Filter the Operations Manager event logs")

6. **Windows Explorer**を開き、**C:\Program Files\Microsoft Monitoring Agent\Agent\Health Service State\Management Packs** フォルダを参照します。

7. Azure Portalからデプロイした機能に対応するマネジメントパックがダウンロードされていることを確認してください。

    ![The management packs for the solutions are displayed.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/loganalytics-mgmtpacks.png "Notice the solution management packs were downloaded")

### Task 5: 適応型アプリケーション制御

1. Azureポータルに切り替えます。

2. **Azure セキュリティ センター** を選択します。

3. ブレードメニューで「**クラウド セキュリティ**」の項目にスクロールし、「**適応型アプリケーション制御**」を選択します。

4. いくつかのグループが表示されていると思いますが、新しく作成したラボVMがあるグループを探します。

   ![Machine groupings is displayed.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/securitycenter-grouping.png "Azure automatically created a group for your VMs")

5. **Publisher whitelisting rules**の項目を展開すると、Google ChromeとNotepad++がピックアップされ、Microsoft Certificatedが関連付けられていることがわかります。

   ![The discovered applications are displayed.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/securitycenter-whitelistingrules.png "Notice the applications that were executed on the machine are displayed")

6. トップメニューで「**グループ設定**」を選択します。

7. 設定内容を確認します。

> **Note**: 2020年6月現在、**Enforce**オプションは一時的に無効になっています。

### Task 6: ファイル整合性の監視

1. Azureポータルに切り替えます。

2. Azure セキュリティ センター を選択します。

3. ブレードメニューで、「**クラウド セキュリティ**」セクションにスクロールし、「**ファイルの整合性の監視**」を選択します。

4. ラボ環境の仮想マシンに関連付けられたログワークスペースが表示されている場合は、「**Upgrade Plan**」を選択し、「**ファイルの整合性の監視を試す**」を選択します。

5. ワークスペースのみを選択し、「**アップグレード**」を選択します。

6. **エージェントをインストールせずに続行します** リンクを選択します。

   ![The continue without installing agents link is highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-enable.png "Select the continue without installing agents link")

7. 表示されている場合は「**有効化**」を、表示されていない場合は単に「ワークスペース」を選択します。

8. メニューで「**設定**」を選択します。

    ![The Settings link is highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-settings.jpg "Select the settings link")

9. **Windows Files "タブを選択します。

10. **+ 追加** を選択します。

11. アイテム名には「**HOSTS**」と入力します。

12. パスに **c:\windows\system32\drivers\etc\\\*** を入力します。
    パスの種類を**フォルダー** に設定します。
    再帰を**オン** に設定します。


13. **保存** を選択します。

    ![The settings page is displayed with the links highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-addentry.jpg "Add a new file integrity monitoring item")

14. **ファイルコンテンツ** タブを選択します。

15. **リンク** を選択し、ラボに紐付いているストレージアカウントを選択します。

    > **Note**: Log Analyticsとその管理パックがすべてのVM上で実行されるまでには、30～60分かかります。このラボにそれほど時間をかけられないかもしれませんが、最終的にどのような結果が得られるかを示すスクリーンショットを用意しています。

    ![The file content page is displayed with the links highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-filecontent.jpg "Link a storage account for file changes")

16. リモートデスクトップ接続で**paw-1**に切り替えます。

17. **c:\windows\system32\drivers\etc\hosts** ファイルを開きます。

18. 次のエントリを追加します。

    ```cmd
    10.0.0.6    linux-1
    ```

19. ファイルを保存します。

20. 約30～60分後、Log Analyticsワークスペースは、ファイル、レジストリ設定、Windowsサービスへの変更を拾い始めます。

    ![The file changes are saved to the logs of the workspace.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-logchanges.png "Review the file change logs for the paw-1 machine in the log analytics workspace")

21. また、ファイルスナップショットがストレージアカウントに表示されるようになります。

    ![The file changes are displayed in the storage account.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/fileintegrity-snapshots.png "The file changes are displayed in the storage account")

### Task 7: ディスクの暗号化

1. Azureポータルに切り替えます。

2. リソースグループを表示します。

3. key vaultを参照します。

4. ブレードメニューの「**設定**」で「**アクセスポリシー**」を選択します。

5. ボリューム暗号化のための **Azure Disk Encryption** チェックボックスを選択します。

   ![The click path above is highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/keyvault-diskencrypt.jpg "Enable the key vault for disk encryption activities")

6. **保存** を選択します。

7. リソースグループを表示します。

8. 仮想マシン「**linux-1**」を選択します。

9. ブレードメニューで「**ディスク**」を選択します。

10. トップメニューで「**暗号化**」を選択します。

    ![The click path above is highlighted.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/diskencryption.jpg "Browse to configure disk encryption for the linux-1 os disk")

11. **Disks to encrypt** で **OS Disk** を選択します。

12. **Select a key vault and key for encryption**」リンクを選択します。

13. ラボの key vault を選択します。

14. キーは「**Create new**」を選択します。

15. 名前には「**vm-disk-key**」と入力します。

16. **Create** を選択します。

    ![Select the lab key vault.](/Hands-on%20lab/images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/diskencryption-selectkeyvault.png "Select the lab key vault")

17. **バージョン**では、新しいバージョンを選択してください。

18. **Select** を選択します。

19. **Save**を選択し、プロンプトが表示されたら**Yes**を選択します。

> **Note**: ディスクの暗号化には時間がかかりますので、次の練習に移ってください。

## Exercise 6: Azure Sentinelのログとレポート

Duration: 20 minutes

この演習では、Azure Sentinelを設定して、ロギングワークスペースを指すようにし、Azure Runbookを実行するカスタムアラートを作成します。

### Task 1: ダッシュボードの作成

1. Azureポータルを開きます。

2. **すべてのサービス** を選択し、「Sentinel」と入力し、「Azure Sentinel」を選択します。

    ![All Services is selected in the left menu, and a search for Sentinel is displayed along with its search results.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image94.jpg "Searching for Sentinel")

3. ブレードで、**+ 追加** を選択し、リソースグループの **Log Analytics** リソースを選択し、**Azure Sentinelの追加** を選択します。

   ![The screenshot displays the Azure workspace found in the resource group.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-12-54-25.jpg "Azure Workspace")

4. ブレード内の「**驚異の管理**」で「**ブック**」を選択します。

5. ワークブックの一覧で、「**Azure AD 監査ログ**」を選択し、「**保存**」を選択します。

6. リージョンを選択し、「**OK**」を選択します。

    ![In the left menu beneath Threat Management the Workbooks item is selected and the Azure AD Audit Logs item is selected beneath the Templates tab on the right.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image95.jpg "Adding a workbook")

7. ワークブックのリストで、**Azure Network Watcher**を選択し、**保存**を選択します。

8. リージョンを選択し、「**OK**」を選択します。

9. **保存されたワークブックを見る** を選択し、新しいワークブックを確認します。

    > **Note**: 対象となるワークブックのクエリのログ分析ワークスペースにデータがない場合があります。

### Task 2: 分析アラートの作成

1. **Azure Sentinel**のワークスペースに戻り、**構成**ブレードのセクションで、**分析**を選択し、**+ 作成**を選択し、**スケジュール済みクエリ ルール** を選択します。

    ![In the left menu beneath Configuration the Analytics item is selected. To the right, the + Create button is expanded and the Scheduled query rule item is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image96.jpg "Adding a analytics alert")

2. **全体**タブで、名前に「**PortScans**」と入力します。

3. F説明には、**A custom rule to detect port scans**と入力し、**次: ルールのロジックを設定** を選択します。

4. **ルールのクエリ** のテキストボックスに、次のように入力します。

    ```PowerShell
    AzureDiagnostics
    | where ruleName_s == 'UserRule_DenyAll' and Type != 'AzureMetric' and type_s == 'block' and direction_s == 'In' and OperationName == 'NetworkSecurityGroupCounters'
    | summarize AggregatedValue = sum(matchedConnections_d) by ruleName_s, primaryIPv4Address_s
    | where AggregatedValue > 0
    ```

    > **Note**: 特定のNSGを対象にしたい場合は `and Resource == 'WEBTRAFFICONLY'` をクエリに追加します。

    ![In this screenshot, the alert simulation shows data after the query has been entered.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image97.jpg "Reviewing alert simulation data")

    > **Note**: ラボでの作業が早かった場合、**AzureMetric** に対応するログデータがLog Analyticsワークスペースにまだないかもしれません。クエリが実行されるまで、15～30分ほど待つ必要があるかもしれません。

    > **Note**: Azure Security CenterとSentinelが導入されてから、バックエンドのロギングが何度か変更され、また、ルールクエリで行われる計算方法も変更されました（クエリ内の時間対クエリ外の時間など）。このクエリの最終的な目的は、ネットワーク・セキュリティ・グループと特定の拒否ルールに対して一連の接続失敗が行われたときに見つけることです。前回公開したラボから何らかの理由で UI/バックエンドが変更された場合は、この目標を達成するためにクエリを変更してください。

5. **エンティティ マッピング** の下で、 **IP** に、 **primaryIPv4Address_s** 列を選択します。 その後 **Add** を選択します。

6. Under **クエリのスケジュール設定** の下で、**クエリの実行間隔** 設定に **5** 分を選択します。

    >**Note**:  これはラボであり、できるだけ早く結果を見たいと思っています。本番環境では、別の時間閾値を選択するとよいでしょう。

7. **次の時間分の過去のデータを参照します** に **2** 時間を設定します。

8. **アラートのしきい値** 、 **クエリ結果件数でアラートを生成する**に、**0** を入力します。

    > **Note:** 実験のために、すぐに閾値を超えるようにしたい。このクエリと値は本番環境では適切ではない可能性があり、学習目的にのみ使用されます。

    現在のデータを確認し、何がアラートのトリガーになるかを判断します。 赤いしきい値の線が青いイベントデータの線と交差していることに注目してください。

    ![A chart is displayed showing the current log data and the alert threshold. The red and blue line intersect in the chart.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-13-26-17.jpg "Results Preview")

9. **次: インシデントの設定 (プレビュー)** インシデントの可能性のある設定を確認します。

10. **次: 自動応答** を選択します。まだ選択できるプレイブックがないことをご注意ください。

11. **次: レビュー** を選択します。

12. **作成** を選択します。

    > **Note**:  アラートが出るまでに数分かかることがあります。 PortScanスクリプトを**paw-1**から何度か実行する必要があるかもしれません。

    ![In the Azure Sentinel Analytics screen beneath the Active Rules tab, the PortScans rule is highlighted in the table and its status shows it is Enabled.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-13-03-56.jpg "PortScan configured")

### Task 3: カスタムアラートのインシデントを調査する

1. メインメニューで「**Azure Sentinel**」を選択します。

2. **Incidents** を選択します。

3. 新しい**PortScans**インシデントを選択します。

    ![In the Azure Sentinel Incidents window, the most recent PortScans security alert is selected from the table.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-13-30-12.jpg "View the new PortScans alert")

    > **Note**: アラートが生成されるまでに15～20分かかることがあります。ポートスキャンスクリプトの実行を継続してログイベントを発生させるか、カスタムアラートの閾値を下げることができます。

4. ダイアログで**すべての詳細を表示**、**調査**を選択します。なお、このボタンが利用可能になるまでには数分かかることがあります。

    ![The incident dialog is displayed with the Investigate button selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image76.jpg "Investigate an incident")
    ![The incident dialog is displayed with the Investigate button selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image76-2.jpg "Investigate an incident")

5. 今後のバージョンでは、アラートに関する洞察や、発砲の原因に関連するリソースを見ることができます。

    ![The Azure Security Insights screen is displayed detailing the lifetime of an alert instance.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image77.jpg)

### Task 4: プレイブックの作成と実行

1. **Azure Sentinel**のブレードで、**オートメーション**を選択します。

2. 新しいウィンドウで、「**+ 新しいプレイブックの追加**」を選択します。

    ![The playbooks blade is displayed with the Playbooks item selected in the left hand menu and the + Add Playbook button selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image79.jpg)

3. **ロジックアプリの作成** ブレードが表示されます。

    - 名前には「**Email**」と入力します。

    - 既存のリソースグループを選択します。

    - **ログ分析の有効化**を**オン**に切り替えて、**azuresecurity**のLog Analyticsワークスペースを選択します。

   ![The information above is entered in the Create logic app blade.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image80.jpg "Enter Create logic app information")

4. 4. **確認および作成**を選択し、**作成**を選択します。 **リソースに移動**、**Logic Apps Designer**がロードされます。デザイナーがロードされない場合は、数分待ってからプレイブックリストを更新します。Email**プレイブックを選択します。

    ![The playbooks list is displayed and the Email playbook is highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-14-40-13.jpg "Playbook List")

5. **Get a notification email when Security Center detects a threat** テンプレートを選択します。

    ![The Logic Apps Designer screen is displayed with a list of templates. The Get a notification email when Security Center detects a threat template is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-14-44-52.jpg "Select Use this template")

6. **このテンプレートを使用する** を選択します。

    ![The Use this template button is selected under Send notification email with alert details from Azure Security Center.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image82.jpg "Select Use this template")

7. **Office 365 Outlook**接続の場合、**+** リンクを選択し、Azure/O365の認証情報を入力します。

    ![The Sign in button is highlighted next to Office 365 Outlook under This logic app will connect to.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-14-48-03.jpg "Sign in to Office 365 Outlook")

    > **Note**: 有効なOffice 365アカウントをお持ちでない場合は、Outlook.comの基本的なメールテンプレートをご利用ください。

8. **Security Center Alert**の接続では、**+** のリンクを選択します。

9. **続行** を選択します。

    ![The Logic app connection blade is displayed.  Outlook and Azure Security Center validation are displayed.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-14-51-29.jpg "Logic App Connection Information")

10. メールアドレスには、あなたの電子メールを入力してください。

11. **保存** を選択します。これで、カスタムセキュリティアラートが使用するLogicAppsベースのメールアラートアクションができました。

    ![Save is highlighted in Logic Apps Designer, and information about the custom security alert appears below.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-14-54-20.jpg "Save the email alert action")

12. 最後に、新しいPlaybookを作成した後、ステータスが**有効**になっていることを確認します。 そうなっていない場合は、メニューから「**有効**」 を選択します。

### Task 5: Jupyter Notebooksの実行

1. **Azure Sentinel**ブレードで、**ノートブック** を選択します。

2. **Azure Sentinel ML ノートブックのファースト ステップ ガイド** の項目を検索します。

    ![The notebook search results are displayed.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/sentinel-getting-started-notebook.jpg "Search for the getting started notebook")

3. 右側のダイアログで「**ノートブックを保存**」を選択します。

4. まだログインしていない場合は、Azure の認証情報を選択すると、GitHub のリポジトリがワークスペースにクローンされます。GitHub のプログレス・メーターが表示されます。

    ![The GitHub progress meter is displayed.](media/2020-01-12-18-06-26.png "GitHub Progress Meter")

5. Jupyter notebooksアプリケーションでノートブックが開くはずです。また、ノートブック・セルを実行するためのコンテナ・カーネルが起動します。

6. ノートブックの指示に従って、各セルを実行します。ノートブックでは、既知の不良行為者やその他の地理的情報など、外部のセキュリティデータをマージするために、サポートされているAPIアカウントをいくつか設定する必要があります。

    ![The getting started Sentinel notebook is displayed.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/jupyter-sentinel.png "Run the notebook steps")

### Task 6: Power BIでのレポート作成

1. **Azure Sentinel**のブラウザウィンドウに戻ります。 **ログ** を選択します。

    >**Note**: You may see a **Welcome to Log Analytics** splash page in the blade.  Select **Get Started**.

    ![The screenshot displays the Welcome to Log Analytics blade.](media/2020-01-12-19-14-49.png "Welcome to Log Analytics")

2. **Active** の下にある**Schema** タブで、**LogManagement** ノードを展開すると、さまざまなオプションが表示されます。

3. スキーマ・ウィンドウで、**AzureDiagnostics** をダブルクリック 、次に **実行** をクリックします。

4. 右上の「**Export**」を選択し、「**Export to Power BI (M Query)**」のリンクを選択します。

    ![The Azure Sentinel Logs screen is displayed. The logs item is selected in the left menu. LogManagement and AzureDiagnostics are selected from the active schema list. The Azure Diagnostics item has an eye icon. A new query tab is shown with the Export item highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image103.jpg "Export a Power BI report query")

    ![The Export item is expanded with the Export to PowerBI (M Query) item highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/2020-01-12-19-17-28.jpg "Export to PowerBI")

5. **開く** を選択すると、Power Query M Languageを使用したテキストドキュメントが表示されます。

6. ドキュメントの指示に従って、Power BIでクエリを実行します。

    ![The instructions at the top of the PowerBIQuery.txt file are highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image88.jpg "Follow the query instructions")

7. **Power BI** を閉じます。

## Exercise 7: コンプライアンスツール（Azure Policy、Secure Score、Compliance Manager）の使用について

Duration: 15 minutes

この演習では、Azureの「Azure Policy」と「Secure Score」の機能をナビゲートする方法を学びます。 また、特定のコンプライアンスポリシーを達成しようとする際に考慮すべき有用なタスクを提供する Compliance Manager ポータルを探索します。

### Task 1: Review a basic Azure Policy

[Azure Portal](https://portal.azure.com)を開きます。 **すべてのサービス** を選択し、「**ポリシー**」と入力します。 項目の一覧から「**ポリシー**」を選択します。

    ![All services are selected in the left menu. In the search box policy is entered. Policy is selected from the filtered list of services.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image104.jpg "Open the Azure Policy blade")

2. ブレードメニューの**コンプライアンス** を選択し、**リソースの全体的なコンプライアンス** のパーセンテージを確認します。

    ![The Compliance item is selected from the left menu. The Policy compliance screen is displayed.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image105.jpg "Open the Azure Policy blade")

3. スコープについては、適切なサブスクリプションが選択されていることを確認し、「**ASC DataProtection (subscription:**)」を選択します。

4. **イニシアティブ コンプライアンス** ブレードでは、コンプライアンスの指標を確認します。


5. 結果エリアにスクロールし、**準拠していないリソース** タブを選択します。

    ![The non-compliant resources tab is highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image106.jpg "Select the Non-Compliant resources tab")

6. フィルター検索ボックスに「**paw-1**」と入力し、表示されたら選択します。

    > **Note**: すぐにリソースが表示されない場合があります。 その場合は、他の非準拠のリソースをスクロールしてください。

7. **Policies**タブを選択して、リソースが準拠していないポリシーを確認します。

    >**Note**: 新しいポリシーが作成されるため、あなたの番号は下の画像とは異なる可能性があります。

    ![The Resource compliance blade for paw-1 is displayed with the non-compliant items highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image107.jpg "Review the non-compliant items")

8. ポリシーの1つを選択します。 ポリシーの**定義の表示**のJSONの定義を確認すると、ARMテンプレート形式に基づいており、準拠していないリソースに設定される特定のプロパティを探していることがわかります。

    ![The policy definition is displayed in JSON format.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image108.jpg "Review the policy definition")

    > **Note**: これらのout of boxなテンプレートを使って独自のポリシーを構築し、ブループリントとして適用することができます。

### Task 2: Azure ブループリントの確認と作成

1. ポリシーブレードの「**Authoring**」の下にある「**Definitions**」を選択します。 これは、サブスクリプションリソースに割り当てるために選択できる、すべての定義済みポリシーのリストです。

    ![A listing of policy definitions on the Policy Blade Definitions screen.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image109.jpg "Review available policy definitions")

2. ポリシーブレードの「**関連サービス**」で「**ブループリント**」を選択します。

3. ブループリントブレードで、**ブループリントの定義**を選択します。

4. **+ ブループリントの作成** を選択します。

    ![The Blueprint definitions screen is displayed with the Blueprint definitions item selected from the left menu. The + Create blueprint menu item is selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image110.jpg "Create a new blueprint")

5. サンプルの設計図を見て、**Start with blank blueprint** を選択します。

    ![The Create blueprint screen is displayed with the Blank blueprint item selected from the list of available samples.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image111.jpg "Create a blank blueprint")

6. 名前には「**GDPRBluePrint**」と入力します。

7. 場所については、楕円形を選択し、ドロップダウンでサブスクリプションを選択します。

8. **選択** を選びます。

    ![New blue print dialog with name and location filled in.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image112.jpg "Set blueprint fields")

9. **次へ: 成果物** を選択します。

10. **+ 成果物の追加** を選択します。

11. Artifact Type（成果物の種類）では、**ポリシーの割り当て**を選択し、利用可能なすべてのポリシーを確認します（この記事の執筆時点では、37の定義と311のポリシーが表示されています）。

12. 検索ボックスで **制限** を入力、 **ストレージ アカウントではネットワークアクセスを制限する必要があります** を選択します。

    ![On the Create blueprint screen, on the Artifacts tab the + Add artifact link is selected beneath the Subscription. In the Add artifact blade, the artifact type of Policy assignment is selected. In the Search textbox, unrestricted is entered. Beneath the Search textbox, the Policy Definitions tab is selected and the Audit unrestricted network access to storage accounts is selected from the list of search results.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image113.jpg "Add an artifact")

    > **Note**: 上記の定義が利用できない場合は、独自の定義を選択してください。

13. **追加** を選択します。

14. **下書きの保存** を選択します。 数分かかる場合があります。 保存操作が終了すると、自動的にブレードが変更されます。

15. 新しいブループリントでは、楕円形を選択してから **ブループリントを発行する** を選択します。

    ![The ellipses menu is expanded for the gdprblueprint blueprint item with the Publish blueprint menu item highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image114.jpg "Publish blueprint dialog")

16. バージョンは、*1.0.0**と入力してください。

17. **公開** を選択します。

18. 新しいブループリントでは、楕円形を選択してから **ブループリントの割り当て** を選択します。

    ![Screen shot showing the Assign blueprint dialog.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image114-2.jpg "Assign blueprint dialog")

19. ページを確認して、**割り当て**を選択します。 このポリシーは、特定のサブスクリプションのすべてのストレージアカウントに対して監査されるようになります。

### Task 3: セキュア スコア

1. Azureポータルで「**すべてのサービス**」を選択し、「**セキュリティ**」と入力して「**セキュリティ センター**」を選択します。

2. セキュリティ センター ブレードで、**クラウド セキュリティ** の下の **セキュア スコア** を選択します。

3. 総合的なセキュアスコアの値を確認してから、カテゴリーの値に気づく。

    ![Screen shot showing Secure score blade and the score and categories highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image115.png "Review Secure Score score and categories")

4. ウィンドウの下半分でサブスクリプションを選択すると、リソース検証に失敗したアイテムが、その特定のレコメンデーションアイテムに割り当てられているスコア値でソートされて表示されます。

5. 推奨ブレードの**An Azure Active Directory administrator should be provisioned for SQL Servers**を選択すると、スコアに影響を与えるための推奨事項の修正方法に関する情報が表示されます。

    ![Screen shot with the Provision an Azure AD Administrator for SQL Server highlighted.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image116.png "Review a security recommendation")

### Task 4: Compliance Manager for Azureの使用

>**Note**: ラボのこの部分を実行するには、追加の権限が必要な場合があります。グローバル管理者にお問い合わせください。

1. ブラウザでService Trust/Compliance Managerのポータル(<https://servicetrust.microsoft.com>)にアクセスします。

2. 上部にある「**Sign in**」を選択すると、Azure ADのログインページにリダイレクトされます。

    ![Sign in is highlighted at the top of the Service Trust/Compliance Manager portal.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image89.jpg "Sign in to Compliance Manager")

3. プロンプトが表示されたら、Azure AD\Office 365 の認証情報を選択するか、サインインしてください。

4. メニューから**コンプライアンス マネージャー** -> **コンプライアンス マネージャー (クラシック)** を選択します。

    ![Compliance Manager Classic is highlight in the menu navigation.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image89.1.jpg "Open Compliance Manager Classic")

5. **標準評価を追加** リンクをクリックします。

6. **新しいグループを作成する** を選択します。名前に **AzureSecurity** を入力、  **次へ** を選択します。**既存のグループからデータをコピーしますか？** トグルを **いいえ** に設定します。**次へ** を選択します。

    ![](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image89.2.jpg)

7. 製品のドロップダウンで、**Azure**を選択します。

    
8. 認証のドロップダウンで、**GDPR**を選択します。

    ![Add a Standard Assessment dialog with Azure and GDPR selected.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image90.jpg)

9. **ダッシュボードに追加** を選択します。 これで、AzureとGDPRの新しい評価が進行中であることがわかります。

    ![Azure GDPR assessment status that shows in progress.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image91.jpg)

10. **Azure GDPR** を選択します。

11. 実装可能な様々なコントロールを確認する。

    ![Several categories of controls are listed on the page.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image91.1.jpg)

12. トップメニューで **トラスト ドキュメント** を選択、  **監査レポート** を選択します。

    ![](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image92.jpg)

13. 様々なタブが表示されますが、「FedRAMP Reports」を選択してください。

14. これらは、Azureのお客様が確認できるように実行され、公開された日付順のFedRAMPレポートのすべてです。表示された項目を選択して、ドキュメントを簡単に確認します。

    ![The FedRAMP Reports report type is highlighted on the Data Protection Standards and Regulatory Compliance Reports page, and Azure - FedRAMP Moderate System Security Plan v3.02 is highlighted at the bottom.](images/Hands-onlabstep-bystep-Azuresecurityprivacyandcomplianceimages/media/image94.jpg "Select the displayed FedRAMP report")

## ハンズオンラボの終了後

Duration: 10 minutes

この演習では、ラボのサポートのために作成されたAzureリソースのプロビジョニングを解除します。

### Task 1: リソースグループの削除

1. Azure ポータルを使用して、メニューから  **リソースグループ** を選択して、このハンズオンラボで使用したリソースグループに移動します。

2. 研究グループの名前を検索して、リストから選択します。

3. コマンドバーで **削除** を選択し、リソースグループ名を再度入力して **削除** を選択して削除を確認します。
T
4. Exercise 3 の Task 3 で作成した Azure Key Vault アプリケーションの削除を忘れないでください。

### Task 2: Azure Defender Pricingの削除

1. Azure Securityの Defenderの価格設定を「**オフ**」に戻してください。


---
---
Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious, and no association with any real company, organization, product, domain name, e-mail address, logo, person, place or event is intended or should be inferred. Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

The names of manufacturers, products, or URLs are provided for informational purposes only, and Microsoft makes no representations and warranties, either expressed, implied, or statutory, regarding these manufacturers or the use of the products with any Microsoft technologies. The inclusion of a manufacturer or product does not imply endorsement of Microsoft of the manufacturer or product. Links may be provided to third-party sites. Such sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement of Microsoft of the site or the products contained therein.

© 2020 Microsoft Corporation. All rights reserved.

Microsoft and the trademarks listed at <https://www.microsoft.com/en-us/legal/intellectualproperty/Trademarks/Usage/General.aspx> are trademarks of the Microsoft group of companies. All other trademarks are the property of their respective owners.
