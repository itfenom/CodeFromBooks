// Chapter6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "gmock\gmock.h"

int _tmain(int argc, _TCHAR* argv[])
{
	testing::InitGoogleMock(&argc, argv);
	RUN_ALL_TESTS();
	std::getchar();
}

