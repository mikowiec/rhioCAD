//============================================================================
// Name        : SolverPointers.cpp
// Author      : Jonathan George
// Version     :

//     Copyright (c) 2009, Jonathan George
//     This program is released under the BSD license. See the file COPYING for details.
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <math.h>
#include <string>
#include "solve.h"
using namespace std;



#define numberOfElements 100
double parameters[numberOfElements],constants[numberOfElements];
double *P,*C;

point points[numberOfElements];
line lines[numberOfElements];

circle circles[numberOfElements];
arc arcs[numberOfElements];
constraint cons[numberOfElements];

void CleanDataSet();
void PointOnPointTest();

int main() {
	//P= parameters;

	//point origin;
	//double zero = 0;
	//origin.x = &zero;
	//origin.y = &zero;

	//constants[0]=6;
	//constants[1]=6;
	//constants[2]=2;
	//constants[3]=M_PI/3;
	//constants[4]=3;

	//points[0].x = &parameters[0];
	//points[0].y = &parameters[1];
	//points[1].x = &parameters[2];
	//points[1].y = &parameters[3];
	//points[2].x = &parameters[4];
	//points[2].y = &parameters[5];
	//points[3].x = &parameters[6];
	//points[3].y = &parameters[7];
	//points[4].x = &constants[0];
	//points[4].y = &constants[1];




	//lines[0].p1 = points[0];
	//lines[0].p2 = points[1];
	//lines[1].p1 = points[1];
	//lines[1].p2 = points[2];


	//cons[0].type = horizontal;
	//cons[0].line1 = lines[0];

	//cons[1].type = vertical;
	//cons[1].line1 = lines[1];

	//cons[2].type = pointOnPoint;
	//cons[2].point1 = points[2];
	//cons[2].point2 = points[4];

	//cons[3].type = pointOnPoint;
	//cons[3].point1 = points[3];
	//cons[3].point2 = points[4];

	//for(int i=0;i<1;i++)
	//{
	//parameters[0]=0;//1x
	//parameters[1]=0;//y
	//parameters[2]=5;//x
	//parameters[3]=0;//y
	//parameters[4]=6;//xstart
	//parameters[5]=5;//y

	//parameters[6]=6;//xend
	//parameters[7]=5;//y



	//int sol;



	//double  *pparameters[100];

	//for(i=0;i<100;i++)
	//{
	//	pparameters[i] = &parameters[i];
	//}

	//sol=solve(pparameters ,8,cons,4,rough);
	//if(sol==succsess)
	//{
	//	cout<<"A good Solution was found"<<endl;
	//}

	//else if(sol==noSolution)
	//{
	//	cout<<"No valid Solutions were found from this start point"<<endl;
	//}
	//for(int i=0;i<8;i++)
	//{
	//	cout<<"Point"<<*pparameters[i]<<endl;
	//}
	//double hey = parameters[0]*parameters[2]+parameters[1]*parameters[3];
	//cout<<"dot product: "<<hey<<endl;

	//double gradF[20];
	//	double *ggradF[20];


	//	for(int i=0;i<20;i++)
	//		{
	//		gradF[i]=0;
	//		ggradF[i]=&gradF[i];
	//		}

	//	derivatives(pparameters, gradF, 4, cons,3);

	//	for(int i=0;i<4;i++) cout<<"GradF["<<i<<"]: "<<*ggradF[i]<<endl;



	//}

	PointOnPointTest();

	return 0;
}

void CleanDataSet()
{
	for (int i=0; i < numberOfElements; i++)
	{
		parameters[i] = 0;
		constants[i] = 0;
	}
	for (int i=0; i < numberOfElements; i++)
	{
		points[i].x = 0;
		points[i].y = 0;
	}
	for (int i=0; i < numberOfElements; i++)
	{
		lines[i].p1 = points[0];
		lines[i].p2 = points[0];
	}
}

void PointOnPointTest()
{
	CleanDataSet();
	
	parameters[0] = 3;
	parameters[1] = 1;
	parameters[2] = 4;
	parameters[3] = 2;

	double  *pparameters[numberOfElements];

	for(int i=0;i<numberOfElements;i++)
	{
		pparameters[i] = &parameters[i];
	}

	points[0].x = &parameters[0];
	points[0].y = &parameters[1];
	points[1].x = &parameters[2];
	points[1].y = &parameters[3];

	cons[0].type = pointOnPoint;
	cons[0].point1 = points[0];
	cons[0].point2 = points[1];

	int sol = 0;
	sol = solve(pparameters, 4, cons, 1, rough);
	if(sol==succsess)
	{
		cout<<"A good Solution was found"<<endl;
	}

	else if(sol==noSolution)
	{
		cout<<"No valid Solutions were found from this start point"<<endl;
	}
	for(int i=0;i<4;i++)
	{
		cout<<"Point"<<*pparameters[i]<<endl;
	}
}

void debugprint(std::string s)
{
	std::cout << s;
}
