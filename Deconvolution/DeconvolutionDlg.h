// DeconvolutionDlg.h : ���� ���������
//

#pragma once
#include "afxwin.h"


// ���������� ���� CDeconvolutionDlg
class CDeconvolutionDlg : public CDialog
{
// ��������
public:
	CDeconvolutionDlg(CWnd* pParent = NULL);	// ����������� �����������

	// ��������� ���������
	CWnd *SignalAndPulseWnd, *ConvolutionWnd, *DeconvolutionWnd;
	CDC *SignalAndPulseDc, *ConvolutionDc, *DeconvolutionDc;
	CRect rect1, rect2, rect3;

	// ���������
	CPen *oldpen, penaxis, pengrid, signalpen, pulsepen, convpen, deconvpen, reconvpen;

	// �����
	CFont *oldfont,	font1, font2;

	// ������
	DWORD dwThread;
	HANDLE hThread;

	void FuncSignalAndPulse();
	void FuncConvolution();
	double function(float*);
	double MHJ(int,float*);
	void FuncShym();
	void Graph1(double*,CDC*,CRect,CPen*,double);
	void Graph2(double*,CPen*,double*,CPen*,CDC*,CRect,double);

// ������ ����������� ����
	enum { IDD = IDD_DECONVOLUTION_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// ��������� DDX/DDV


// ����������
protected:
	HICON m_hIcon;

	// ��������� ������� ����� ���������
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	double A1;
	double A2;
	double A3;
	double x1;
	double x2;
	double x3;
	double Sigma1;
	double Sigma2;
	double Sigma3;
	double Apulse;
	double Sigmapulse;
	int count;
	double iter;
	double *Signal;
	double *Pulse;
	double *Convolution;
	double *DeconvSignal;
	float *lambda;
	double Min,Max,Min1,Max1,Min2,Max2;
	char znach[1000], zn[100];
	bool SignalAndPulseFlag,ConvolutionFlag,DeconvolutionFlag,sig,pul,conv,lam;
	double xx0,xxmax,yy0,yymax,xxi,yyi;
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	CEdit Funcional;
	double �;
};
