// Deconvolution.h : ������� ���� ��������� ��� ���������� PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�������� stdafx.h �� ��������� ����� ����� � PCH"
#endif

#include "resource.h"		// �������� �������


// CDeconvolutionApp:
// � ���������� ������� ������ ��. Deconvolution.cpp
//

class CDeconvolutionApp : public CWinApp
{
public:
	CDeconvolutionApp();

// ���������������
	public:
	virtual BOOL InitInstance();

// ����������

	DECLARE_MESSAGE_MAP()
};

extern CDeconvolutionApp theApp;