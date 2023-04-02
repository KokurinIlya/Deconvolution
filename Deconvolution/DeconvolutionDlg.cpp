// DeconvolutionDlg.cpp : ���� ����������
//

#include "stdafx.h"
#include "Deconvolution.h"
#include "DeconvolutionDlg.h"
#include "math.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// ���������� ���� CAboutDlg ������������ ��� �������� �������� � ����������

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// ������ ����������� ����
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // ��������� DDX/DDV

// ����������
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// ���������� ���� CDeconvolutionDlg




CDeconvolutionDlg::CDeconvolutionDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CDeconvolutionDlg::IDD, pParent)
	, A1(1)
	, A2(0)
	, A3(0)
	, x1(16)
	, x2(0)
	, x3(0)
	, Sigma1(2)
	, Sigma2(2)
	, Sigma3(2)
	, Apulse(1)
	, Sigmapulse(3)
	, count(32)
	, SignalAndPulseFlag(false)
	, ConvolutionFlag(false)
	, DeconvolutionFlag(false)
	, sig(false)
	, pul(false)
	, conv(false)
	, lam(false)
	, �(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CDeconvolutionDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_EDIT1, A1);
	DDX_Text(pDX, IDC_EDIT2, A2);
	DDX_Text(pDX, IDC_EDIT3, A3);
	DDX_Text(pDX, IDC_EDIT4, x1);
	DDX_Text(pDX, IDC_EDIT5, x2);
	DDX_Text(pDX, IDC_EDIT6, x3);
	DDX_Text(pDX, IDC_EDIT7, Sigma1);
	DDX_Text(pDX, IDC_EDIT8, Sigma2);
	DDX_Text(pDX, IDC_EDIT9, Sigma3);
	DDX_Text(pDX, IDC_EDIT10, Apulse);
	DDX_Text(pDX, IDC_EDIT11, Sigmapulse);
	DDX_Control(pDX, IDC_EDIT12, Funcional);
	DDX_Text(pDX, IDC_EDIT13, �);
}

BEGIN_MESSAGE_MAP(CDeconvolutionDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON1, &CDeconvolutionDlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CDeconvolutionDlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CDeconvolutionDlg::OnBnClickedButton3)
END_MESSAGE_MAP()


// ����������� ��������� CDeconvolutionDlg

BOOL CDeconvolutionDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// ���������� ������ ''� ���������...'' � ��������� ����.

	// IDM_ABOUTBOX ������ ���� � �������� ��������� �������.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// ������ ������ ��� ����� ����������� ����. ����� ������ ��� �������������,
	//  ���� ������� ���� ���������� �� �������� ����������
	SetIcon(m_hIcon, TRUE);			// ������� ������
	SetIcon(m_hIcon, FALSE);		// ������ ������

	// TODO: �������� �������������� �������������

	// ���� ������� � ���������� ��������������
	SignalAndPulseWnd = GetDlgItem(IDC_SignalAndPulse);
	SignalAndPulseDc = SignalAndPulseWnd->GetDC();
	SignalAndPulseWnd -> GetClientRect(&rect1);
	
	// ���� ������
	ConvolutionWnd = GetDlgItem(IDC_Convolution);
	ConvolutionDc = ConvolutionWnd->GetDC();
	ConvolutionWnd -> GetClientRect(&rect2);
	
	// ���� ������������
	DeconvolutionWnd = GetDlgItem(IDC_Deconvolution);
	DeconvolutionDc = DeconvolutionWnd->GetDC();
	DeconvolutionWnd -> GetClientRect(&rect3);

	// ����� ��� ���������
	penaxis.CreatePen(0,2,RGB(0,0,0));//���
	pengrid.CreatePen(PS_DOT,1,RGB(100,100,100));//�����
	signalpen.CreatePen(0,1,RGB(0,0,255));//������
	pulsepen.CreatePen(0,1,RGB(255,0,0));//���. ���-��
	convpen.CreatePen(0,1,RGB(255,0,255));//����������
	deconvpen.CreatePen(0,1,RGB(0,255,0));//������������

	// ������ ��� ��������
	font1.CreatePointFont(120, _T("Arial"), SignalAndPulseDc);
	font2.CreatePointFont(80, _T("Arial"), SignalAndPulseDc);
		
	return TRUE;  // ������� �������� TRUE, ���� ����� �� ������� �������� ����������
}

void CDeconvolutionDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

//  ��� ���������� ������ ����������� � ���������� ���� ����� ��������������� ����������� ���� �����,
//  ����� ���������� ������. ��� ���������� MFC, ������������ ������ ���������� ��� �������������,
//  ��� ������������� ����������� ������� ������.

void CDeconvolutionDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // �������� ���������� ��� ���������

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// ������������ ������ �� ������ ����������� ��������������
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// ��������� ������
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
		UpdateData(false);
		
		if(SignalAndPulseFlag == true) 
			Graph2(Signal, &signalpen, Pulse, &pulsepen, SignalAndPulseDc, rect1, count);
		
		if(ConvolutionFlag == true) 
			Graph1(Convolution, ConvolutionDc, rect2, &convpen, count);
		
		if(DeconvolutionFlag == true) 
			Graph2(Signal, &signalpen, DeconvSignal, &deconvpen, DeconvolutionDc, rect3, count);
	}
}

// ������� �������� ��� ������� ��� ��������� ����������� ������� ��� �����������
//  ���������� ����.
HCURSOR CDeconvolutionDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

// ������� ������
DWORD WINAPI MyProc(PVOID pv)
{
	CDeconvolutionDlg *p = (CDeconvolutionDlg*)pv;
	p->MHJ(p->count,p->lambda);
	return 0;
}

// ���������� ������� � ���������� ��������������
void CDeconvolutionDlg::FuncSignalAndPulse()
{
	// �������� �������� ��������� ������� � ���������� ��������������
	UpdateData(true);
	if(sig==true) delete [] Signal;
	if(pul==true) delete [] Pulse;
	Signal=new double[count];
	Pulse=new double[count];
	// ���������� ������� ��������� �������
	for(int i=0; i<count; i++)
	{
		Signal[i]=A1*exp(-(x1-i)*(x1-i)/(Sigma1*Sigma1))+A2*exp(-(x2-i)*(x2-i)/(Sigma2*Sigma2))+A3*exp(-(x3-i)*(x3-i)/(Sigma3*Sigma3));
	}
	FuncShym();
	sig=true;
	// ���������� ������� ���������� ��������������
	for(int i=0; i<count; i++)
	{
		Pulse[i]=Apulse*exp(-(i-count/2)*(i-count/2)/(Sigmapulse*Sigmapulse));
	}
	double *Pulse2 = new double[count];
	for(int i=0; i<count; i++)
	{
		Pulse2[i]=Pulse[i];
	}
	for(int i=0; i<count/2; i++)
	{
		Pulse[i]=Pulse2[i+count/2];
		Pulse[i+count/2]=Pulse2[i];
	}
	delete [] Pulse2;
	pul=true;
}

// ���������� ������
void CDeconvolutionDlg::FuncConvolution()
{
	// ������������  ������� ������
	UpdateData(true);
	if(conv == true) delete [] Convolution;
	Convolution=new double[count];
	// ���������� ������� �������
	for(int i=0; i<count; i++)
	{
		iter=0;
		for(int j=0; j<count; j++)
		{
			int m=i-j;
			if(m<0)
			{
				m+=count;
			}
			iter+=Pulse[m]*Signal[j];
		}
		Convolution[i]=iter;
	}
	conv=true;
}

// ���������� �����������
double CDeconvolutionDlg::function(float *lambda)
{
	double sumk=0;
	for(int i=0; i<count; i++)
	{
		sumk=0;
		for(int j=0; j<count; j++)
		{
			if((i-j)<0)	
			{
				sumk+=lambda[j]*Pulse[i-j+count];
			}
			else 
				sumk+=lambda[j]*Pulse[i-j];
		}
		DeconvSignal[i]=exp(-1-sumk);
	}
	double ret_value = 0;
	double ss=0;
	for(int i=0; i<count; i++)
	{
		ss=0;
		for(int j=0; j<count; j++)
		{
			if((j-i)<0)
			{
				ss+=DeconvSignal[j]*Pulse[j-i+count];
			}
			else ss+=DeconvSignal[j]*Pulse[j-i];
		}
		ret_value+=pow((Convolution[i]-ss),2);
	}
	return ret_value;
}

// ����� ����-������
double CDeconvolutionDlg::MHJ(int kk, float* x)
{
	// kk - ���������� ����������; x - ������ ����������
	double  TAU=1.e-6f; // �������� ���������� 
	int i, j, bs, ps;
	double z, h, k, fi, fb;
	double *b=new double[kk];
	double *y=new double[kk];
	double *p=new double[kk];
	h=1;	
	x[0]=1;
	for(i=1; i<kk; i++)  
	{
		x[i]=(double)rand()/RAND_MAX; // �������� ��������� �����������
	}

	k=h;
	for(i=0; i<kk; i++)
    {
		y[i]=p[i]=b[i]=x[i];
    }
	fi=function(x);
	ps=0;
	bs=1;
	fb=fi;
	j=0;
	while(1)
	{
		x[j]=y[j]+k;
		z=function(x);
		sprintf(zn,"%5.10f",z);
		Funcional.SetWindowTextW((CString)zn);
		if (z>=fi)
		{
			x[j]=y[j]-k;
			z=function(x);
			if(z<fi) 
			{
				y[j]=x[j];
			}
			else  x[j]=y[j];
		}
		else  y[j]=x[j];
		fi=function(x);
		if (j<kk-1)
		{  
			j++;
			continue;
		}
		if (fi+1e-8>=fb) 
		{
			if (ps==1 && bs==0)
			{
				for(i=0; i<kk; i++)
				{
					p[i]=y[i]=x[i]=b[i];
				}
				z=function(x);
				bs=1;   
				ps=0;   
				fi=z;   
				fb=z;  
				j=0;
				continue;
			}
			k/=10.;
			if (k<TAU)
			{
				break;
			}
			j=0;
			continue;
		}
		for(i=0; i<kk; i++) 
		{
			p[i]=2*y[i]-b[i];
			b[i]=y[i];
			x[i]=p[i];
			y[i]=x[i];
		}
		z=function(x);
		fb=fi;   
		ps=1;   
		bs=0;   
		fi=z; 
		j=0;
		Invalidate(0);
	} //  end of while(1)
	for(i=0; i<kk; i++) 
	{
		x[i]=p[i];
	}
	delete b;
	delete y;
	delete p;
	return fb;
}

// ���������� � ���������� ����
void CDeconvolutionDlg::FuncShym()
{
	double *Shum = new double [count];
	double *n = new double [count]; 
	double ensig=0;
	double ensh=0;
	for (int i=0; i<count; i++)
	{
		Shum[i]=0;
		for (int j=0; j<12; j++)
		{
			Shum[i]+=(((double) rand()/(double) RAND_MAX)*2-1)/12;
		}
		ensig+=pow(Signal[i],2);
		ensh+=pow(Shum[i],2);
	}
	double norm=ensig/ensh*�/100;
	for (int i=0; i<count; i++)
	{
		n[i]=Shum[i]*sqrt(norm);
		Signal[i]=Signal[i]+n[i];
	}
	delete [] n;
	delete [] Shum;
}

// ��������� ������ �������
void CDeconvolutionDlg::Graph1(double *Mass, CDC* WinDc, CRect WinPic, CPen *graphpen, double AbsMax)
{
	// ����� ������������� � ������������ ��������
	Min=Mass[0];						 
	Max=Mass[0];
	for(int i=1; i<count; i++)				
	{										
		if (Mass[i]<Min)				
		{									
			Min=Mass[i];				
		}										
		if (Mass[i]>Max)				
		{									
			Max=Mass[i];			
		}		
	}
	// ���������
	// �������� ��������� ����������
	CBitmap bmp;
	CDC* MemDc;
	MemDc = new CDC;
	MemDc->CreateCompatibleDC(WinDc);
	bmp.CreateCompatibleBitmap(WinDc, WinPic.Width(), WinPic.Height());
	CBitmap* pBmp = (CBitmap*)MemDc->SelectObject(&bmp);
	// ������� ���� ������� ����� ������
	MemDc->FillSolidRect(WinPic, RGB(255,255,255));
	// ��������� ����� ���������
	oldpen = MemDc->SelectObject(&pengrid);
	// ������������ ����� ����� ���������
	for(double i = WinPic.Width()/15; i<WinPic.Width(); i += WinPic.Width()/15)
	{
		MemDc->MoveTo(i, 0);
		MemDc->LineTo(i, WinPic.Height());
	}
	// �������������� ����� ����� ���������
	for(double i=WinPic.Height()/10; i<WinPic.Height(); i+=WinPic.Height()/10)
	{
		MemDc->MoveTo(0, i);
		MemDc->LineTo(WinPic.Width(), i);
	}
	// ��������� ����
	oldpen = MemDc->SelectObject(&penaxis);
	// ��������� ��� X
	MemDc->MoveTo(0, WinPic.Height()*9/10); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	MemDc->MoveTo(WinPic.Width()-15, WinPic.Height()*9/10+4); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	MemDc->MoveTo(WinPic.Width()-15, WinPic.Height()*9/10-4); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	// ��������� ��� Y
	MemDc->MoveTo(WinPic.Width()*1/15, WinPic.Height()); MemDc->LineTo(WinPic.Width()*1/15, 0);
	MemDc->MoveTo(WinPic.Width()*1/15-4, 15); MemDc->LineTo(WinPic.Width()*1/15, 0);
	MemDc->MoveTo(WinPic.Width()*1/15+4, 15); MemDc->LineTo(WinPic.Width()*1/15, 0);
	// ������� ����
	// ��������� ����������� ���� ������
	MemDc->SetBkMode(TRANSPARENT);
	// ��������� ������
	MemDc->SelectObject(&font1);
	// ������� ��� X
	MemDc->TextOut(WinPic.Width()*14/15+4, WinPic.Height()*9/10+2, CString ("x"));
	// ������� ��� Y
	MemDc->TextOut(WinPic.Width()*1/15+10, 0, CString ("Ampl"));
	// ����� ������� ��� ���������
	xx0 = WinPic.Width()*1/15; xxmax = WinPic.Width();									
	yy0 = WinPic.Height()/10; yymax = WinPic.Height()*9/10;
	// ���������
	oldpen = MemDc->SelectObject(graphpen);	
	MemDc->MoveTo(xx0, yymax+(Mass[0] - Min) / (Max - Min) * (yy0 - yymax));
	for(int i = 0; i < count; i++)								
	{																
		xxi=xx0+(xxmax-xx0)*i/(count-1);								
		yyi=yymax+(Mass[i]-Min)/(Max-Min)*(yy0-yymax);		
		MemDc->LineTo(xxi,yyi);									
	}
	// ����� �������� ��������
	// �� ��� X
	MemDc->SelectObject(&font2);
	for(int i = 1; i<6; i += 1)
	{
		sprintf(znach, "%5.1f", i*AbsMax/6);
		MemDc->TextOut(i*WinPic.Width()/6, WinPic.Height()*9/10+2, CString(znach));
	}
	// �� ��� Y
	for(int i = 0; i<5; i++)
	{
		sprintf(znach, "%5.2f", Min + i * (Max - Min) / 4);
		MemDc->TextOut(0, WinPic.Height()*(9-2*i)/10, CString(znach));
	}
	// ����� �� �����
	WinDc->BitBlt(0, 0, WinPic.Width(), WinPic.Height(), MemDc, 0, 0, SRCCOPY);
	delete MemDc;
}

// ��������� ���� ��������
void CDeconvolutionDlg::Graph2(double *Mass1, CPen* graph1pen, double *Mass2, CPen* graph2pen, CDC* WinDc, CRect WinPic, double AbsMax)
{
	// ����� ������������� � ������������ ��������
	Min1=Mass1[0]; 						 
	Max1=Mass1[0];
	Min2=Mass2[0];
	Max2=Mass2[0];
	for(int i=1; i<count; i++)				
	{										
		if (Mass1[i]<Min1)				
		{									
			Min1=Mass1[i];				
		}										
		if (Mass1[i]>Max1)				
		{									
			Max1=Mass1[i];			
		}		
		if (Mass2[i]<Min2)				
		{									
			Min2=Mass2[i];				
		}										
		if (Mass2[i]>Max2)				
		{									
			Max2=Mass2[i];			
		}			
	}
	if(Max2>Max1)
	{
		Max=Max2;
	}
	else
	{
		Max=Max1;
	}
	if(Min2<Min1)
	{
		Min=Min2;
	}
	else
	{
		Min=Min1;
	}
	// ���������
	// �������� ��������� ����������
	CBitmap bmp;
	CDC* MemDc;
	MemDc = new CDC;
	MemDc->CreateCompatibleDC(WinDc);
	bmp.CreateCompatibleBitmap(WinDc, WinPic.Width(), WinPic.Height());
	CBitmap* pBmp = (CBitmap*)MemDc->SelectObject(&bmp);
	// ������� ���� ������� ����� ������
	MemDc->FillSolidRect(WinPic, RGB(255,255,255));
	// ��������� ����� ���������
	oldpen = MemDc->SelectObject(&pengrid);
	// ������������ ����� ����� ���������
	for(double i = WinPic.Width()/15; i<WinPic.Width(); i += WinPic.Width()/15)
	{
		MemDc->MoveTo(i, 0);
		MemDc->LineTo(i, WinPic.Height());
	}
	// �������������� ����� ����� ���������
	for(double i = WinPic.Height()/10; i < WinPic.Height(); i += WinPic.Height()/10)
	{
		MemDc->MoveTo(0, i);
		MemDc->LineTo(WinPic.Width(), i);
	}
	// ��������� ����
	oldpen = MemDc->SelectObject(&penaxis);
	// ��������� ��� X
	MemDc->MoveTo(0, WinPic.Height()*9/10); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	MemDc->MoveTo(WinPic.Width()-15, WinPic.Height()*9/10+4); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	MemDc->MoveTo(WinPic.Width()-15, WinPic.Height()*9/10-4); MemDc->LineTo(WinPic.Width(), WinPic.Height()*9/10);
	// ��������� ��� Y
	MemDc->MoveTo(WinPic.Width()*1/15, WinPic.Height()); MemDc->LineTo(WinPic.Width()*1/15, 0);
	MemDc->MoveTo(WinPic.Width()*1/15-4, 15); MemDc->LineTo(WinPic.Width()*1/15, 0);
	MemDc->MoveTo(WinPic.Width()*1/15+4, 15); MemDc->LineTo(WinPic.Width()*1/15, 0);
	// ������� ����
	// ��������� ����������� ���� ������
	MemDc->SetBkMode(TRANSPARENT);
	// ��������� ������
	MemDc->SelectObject(&font1);
	// ������� ��� X
	MemDc->TextOut(WinPic.Width()*14/15+4, WinPic.Height()*9/10+2, CString ("x"));
	// ������� ��� Y
	MemDc->TextOut(WinPic.Width()*1/15+10, 0, CString ("Ampl"));
	// ����� ������� ��� ���������
	xx0 = WinPic.Width()*1/15; xxmax = WinPic.Width();									
	yy0 = WinPic.Height()/10; yymax = WinPic.Height()*9/10;
	// ��������� ������� �������
	oldpen = MemDc->SelectObject(graph1pen);	
	MemDc->MoveTo(xx0, yymax+(Mass1[0]-Min)/(Max-Min)*(yy0-yymax));
	for(int i = 0; i < count; i++)								
	{																
		xxi=xx0+(xxmax-xx0)*i/(count-1);								
		yyi=yymax+(Mass1[i]-Min)/(Max-Min)*(yy0-yymax);		
		MemDc->LineTo(xxi, yyi);									
	}
	// ��������� ������� �������
	oldpen = MemDc->SelectObject(graph2pen);	
	MemDc->MoveTo(xx0, yymax+(Mass2[0]-Min)/(Max-Min)*(yy0-yymax));
	for(int i = 0; i < count; i++)								
	{																
		xxi=xx0+(xxmax-xx0)*i/(count-1);								
		yyi=yymax+(Mass2[i]-Min)/(Max - Min)*(yy0-yymax);		
		MemDc->LineTo(xxi, yyi);									
	}	
	// ����� �������� ��������
	// �� ��� X
	MemDc->SelectObject(&font2);
	for(int i = 1; i<6; i += 1)
	{
		sprintf(znach, "%5.1f", i*AbsMax/6);
		MemDc->TextOut(i*WinPic.Width()/6, WinPic.Height()*9/10+2, CString(znach));
	}
	// �� ��� Y
	for(int i = 0; i<5; i++)
	{
		sprintf(znach, "%5.2f", Min+i*(Max-Min)/4);
		MemDc->TextOut(0, WinPic.Height()*(9-2*i)/10, CString(znach));
	}
	// ����� �� �����
	WinDc->BitBlt(0, 0, WinPic.Width(), WinPic.Height(), MemDc, 0, 0, SRCCOPY);
	delete MemDc;
}

// ������ ������ + ���. ���-��
void CDeconvolutionDlg::OnBnClickedButton1()
{
	FuncSignalAndPulse();
	SignalAndPulseFlag = true;
	Graph2(Signal, &signalpen, Pulse, &pulsepen, SignalAndPulseDc, rect1, count);
}

// ������ ����������
void CDeconvolutionDlg::OnBnClickedButton2()
{
	FuncConvolution();
	ConvolutionFlag = true;
	Graph1(Convolution, ConvolutionDc, rect2, &convpen, count);
}

// ������ ������������
void CDeconvolutionDlg::OnBnClickedButton3()
{
	lambda = new float[count];
	for(int i=0;i<count;i++) 
		lambda[i]=0;
	DeconvSignal = new double[count];
	hThread = CreateThread(NULL,0,MyProc,this,0,&dwThread);
	DeconvolutionFlag = true;
	Graph2(Signal, &signalpen, DeconvSignal, &deconvpen, DeconvolutionDc, rect3, count);
}