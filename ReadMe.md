2021/12/1
������o�āA�uEntityFrameworkSample�v������Ă݂�
	�EDomain
		User������	Domain�t�H���_�[���܂���� Users�t�H���_�[�����
			�����ŔY�ށB�A�m�e�[�V��������Ȃ����A�v���p�e�B�[��get�����ɏo���Ȃ�
			����cleanArchitecture��sqlServer�ł��Ȃ�Ƃ�Oracle�œ����Ȃ���������Ă݂�
				��EntityFramework���C���X�g�[��
					dbo���Ȃ��Ƃ��o��B
					���X�L�[�}��OnModelCreating�ɒǉ��Ő���
						�Ȃ񂩃f�[�^������Ă��ꂽ
			��
			�Y�݂̌��ʂ��l����		
				�������čl����
					Domain��Customers�t�H���_�[�ACustomer�����
						������ Setter Getter�őΉ�����
						Common�t�H���_�[��
							IEntity�쐬�ς�
	�EApplication			
		Customers���쐬			
			Commands	
				Create��Command�łł������Ȃ����Ă݂����Bkokokara
				�����Ȃ�UseCase
				CreateCustomer�t�H���_�[�쐬
					CreateCustomerModel�쐬
					ICreateCustomerModel�쐬
					CreateCustomerCommand�쐬
					Factory�t�H���_�[�쐬
						ICustomerFactory�쐬
						CustomerFactory�쐬

			Queries
				�����쐬
				GetCustomerList�쐬
					CustomerModel�쐬		����͕\���p�H
					IGetCustomersListQuery	�擾�p�H
					GetCustomersListQuery	�쐬
						IDatabaseService������
		Microsoft.EntityFrameworkCore�C���X�g�[��
		Interfaces
			�iDomain���Q�Ƃɒǉ��j
			DB���̃f�[�^�擾�p�쐬			�{����IRepository�@�e�e�[�u�����ƁH
			IDatabaseService				�S�e�[�u�����܂�	Database�ƌ��߂��Ă�
				IDbSet�����܂������Ȃ�				
					��DbSet�ɕύX(FramworkCore�Ȃ̂�)
				������Customer���g���B
	�EPersistence	
		(Application���Q�Ƃɒǉ�)
		OracleEntityFrameworkCore�C���X�g�[��
		DatabaseService�쐬
		InitialCreate���s���Ă݂�(Migration)	
			Core.Design(ver6)
			Core.tool(ver6)
			�����C���X�g�[��
			�p�b�P�[�W�}�l�[�W���[�R���\�[�����
				Add-Migration InitialCreate�@
					���s	
						���X�^�[�g�A�b�v�v���W�F�N�g�ƁA�u����̃v���W�F�N�g�v�ύX
						��
						���s �Ȃ񂩐ڑ��ݒ肪�K�v�H�H				kokokara
						Method 'get_QueryProvider' in type 'Microsoft.EntityFrameworkCore.Storage.Internal.RelationalDatabaseFacadeDependencies'
							��mix diffrence version?
							��
							���������B
								Application�ɃC���X�g�[�������uMicrosoft.EntityFrameworkCore�v��ver7�ň���Ă��� ver6�̍Ō�ɐݒ�
								�iOracle�q�����ĂȂ��Ă��ǂ������j
				��
				Update-Database
					Oracle�Ƀe�[�u���쐬����
	�EPresentation�쐬
		�iForm�Ƃ͕����č쐬���Ă݂�j
		 (Application�ADomain�APersistence���Q�Ƃɒǉ�)

		Customers��Controller��ViewModel���AUseCase�ł݂�������܂������č���Ă݂�

		�EMicrosoft.Extensions.DependencyInjection���C���X�g�[��	�����ver6.0.1�ɗ��Ƃ�
		��
		�����ŋ����N���Ă鎖�𔭌�
		Microsoft.EntityFrameworkCore.Relational" �̈قȂ�o�[�W�����ԂŁA�����ł��Ȃ�������������܂���
		�c�[�����I�v�V�������v���W�F�N�g�y�с��r���h��msbuild �v���W�F�N�g�r���h �o�� �ڍׂ�
		������6.0.3��I��ł���ۂ��B����DLL��6.0.11�������Ă�B
		��
		Microsoft.EntityFrameworkCore.Relational��6.0.11��nuget�ŃC���X�g�[���i�����܂ŁA�R���Ԃ��炢���������j

		�EStartUp���쐬
		�ECustomers�t�H���_�[�쐬
			Models�t�H���_�[�쐬
				CreateCustomerViewModel�쐬
			Services�t�H���_�[�쐬
				ICreateCustomerViewModelFactory �쐬
				CreateCustomerViewModelFactory �쐬
			CustomerController�쐬
				UseCase�g�����͕ۗ��B
					�܂��́AAppication��Command�ł���Ă݂���

				�\�����W�b�N
					Index�ō쐬�B

				�쐬���W�b�N
					Create�ō쐬

				�������ʂ���Call���Ă݂�
						
					Index�ŕ\��
						��OK
					Create�ō쐬��Index�ōĕ\��
						��OK
				�Ō��ICustomerController���K�v���H
					������

				useCase�݂����ɂȂ�Ȃ��H�@callback���Ȃ�		kokokara
					UserCreateSubject�݂����Ȃ̂��Ȃ��B�ǂ��ɒu���ׂ��H

	�EGUIS�ɁiPresentation���Q�Ƃɒǉ��j
		Startup.Run���R�[��
		
			

		
		


	�EIRepository�͍��H���Ȃ��H


	�EInfrastructure
		User�̃}�C�N�O���[�V���������
		
	�ESales��Update����������
		Customers��Update��

	�E�\�����ǂ���邩�H��ʂɎ������邩�H�ʂ�ControlLibrary��邩�H

	�E�Ō��.net core ��CleanArchitecture���݂āA�l���������킹����

	DependencyInjection���l����

2022/11/24
�R���\�[���ŁA�T���v������Ă݂�
https://www.youtube.com/watch?v=SryQxUeChMc&t=2s
	Nuget��
		�EODP frameworkcore
		�Ecore design
		�Ecore tools
	�p�b�P�[�W�}�l�[�W���[��(����tool���邩�炩��)
		Add-Migration InitialCreate�@
			�����s�B����̃v���W�F�N�g��ύX�Ő���
			Migrations�t�H���_�[����ς�
		Update-Database
			�����s�B�֘A�L�[�̗񖼂����������̂ŕύX
				������
	Customer Entity�ɍ��ڒǉ������Ƃ��̃}�C�O���[�V����
		Add-Migration AddEmail		���O�ύX
		��
		Update-Database		�����炭�V��������I��ł���Ă�C������
			����
	�EUpdate Order By
		��OK
https://www.youtube.com/watch?v=DCYVfLT5_QI
	Scaffoloding data existing database
	��
	�p�b�P�[�W�}�l�[�W���[
		Scaffold-DbContext "User ID=awc; Password=awc; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=DAS)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));" Oracle.EntityFrameworkCore -ContextDir Data2 -OutputDir Models2
		��OK
		��
		�Ō�� -DataAnnotation������
	��
	�Q��ނ̃A�v���[�`������݂���
		�E���ꏊ�ύX �ǋL
			Models2/Generated -ContextNamespace�@ContosoPizza.Data2 -Namespace ContosoPizza.Models2
			��������PartialClass�ɂȂ��Ă���B
			��̊K�w�ɓ����N���X���g���āA�ǉ��ӏ����L�ډ\
		�E
����Asp.netCore�̓��悾�������{�B
	connectionstring��閧�ɂ�����A�e��e�[�u����Scaffolding������
https://www.youtube.com/watch?v=moRmKo3nrN4
	�ʂ̃f�[�^�x�[�X
	<StartWorkingDirectory>���쐬
https://www.youtube.com/watch?v=jgESld7U5Bw
	�Ō� Peformance Up
		�EAsNoTracking
		�Eeager Loading
		  lazy  Loading
			proxies���C���X�g�[��
				useLazyLoadingProxies	DI���ɃR�[��
		�ESplit queries
			asSplitQuery���\�b�h���R�[��
		�E�P��SQL�̎��s
			FromSqlInterpolated���R�[��
		�Econtext pooling
			AddDbContextPool�ɕύX




2022/11/22 �쐬�J�n
��U�A�b�v

�EEntityFrameWork��Oracle19c�ڑ��A�e�[�u���A�f�[�^�쐬�܂ł���������
�@�{�^�������ŁA���O��o�^
�@�����ňꗗ��\��
�@�\�Ȍ���uClean Architecture�v�Ŏ���
	�T���v����Architecture��^�����āAView�Ń��X�g�{�b�N�X�ɕ\�����銴��
		FormMainViewer�ŕ`�悷�銴���B
�@�o�[�W�������グ�邱��
�EPresentation�ɉ�ʂ��܂ނ̂��H�ʓr�p�ӂ���̂��H
�EModelFirst�̏����l�쐬
�E������e�[�u����Models�쐬

