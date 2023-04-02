// Deconvolution.h : главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить stdafx.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// CDeconvolutionApp:
// О реализации данного класса см. Deconvolution.cpp
//

class CDeconvolutionApp : public CWinApp
{
public:
	CDeconvolutionApp();

// Переопределение
	public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CDeconvolutionApp theApp;