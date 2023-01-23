// twosum.cpp : This file contains the 'main' function. Program execution begins and ends there.

//Problem:
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

#include <iostream>
#include <vector>
using namespace std;

vector<int> twoSum(vector<int>& nums, int target)
{
	//brute force: subtract initial number from target and compare to current 
	int numsize = nums.size();
	int j = 1;
	for (int i = 0; i < numsize; i++) {
		int numsize = nums.size(); //outer loop select first number from begin to end
		int j = 1;
		for (int i = 0; i < numsize; i++) {
			for (int k = j; k < numsize; k++) {
				if (nums[k] == target - nums[i]) //current number compare to needed number 
					return { i, k };
				//return { nums[i], nums[j] };//return the numbers instead
			}
			j++;
		}
	}
	return {};//no satisfying result 
}

int main()
{ 
	//Inputs
	//vector<int> inNum = { 2, 7, 11, 15 }; //all number
	//int inTarget = 9;
	vector<int> inNum = { 2, 5, 5, 15 }; //all number
	int inTarget = 10;
	vector<int> ans = twoSum(inNum, inTarget);
	for (int i : inNum) {
		cout << i << " "; //print all elements inNum
	}
	cout << endl;
	cout << "Result: ";
	for (int i : ans) {
		cout << i << " "; //print results
	}
	cout << endl;
	
}
