Feature: Seller_Add Profile Details

As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@Test(priority=1)
Scenario: User updates the profile name, availability, hours and earn target in his/her profile
	Given User is logged into Mars application successfully
	When User navigate to profile page
	And User update the profile name, availability, hours and earn target 
	Then the profile should be updated successfully 

@Test(priority=2)
Scenario: User updates the description in his/her profile
	Given User is logged into Mars application successfully
	When User navigate to profile page
	And User update the description 
	Then the profile description should be updated successfully 

@Test(priority=3)
Scenario: User updates the languages in his/her profile
	Given User is logged into Mars application successfully
	When User navigate to profile page
	And User update the languages 
	Then the profile language should be updated successfully 

#Scenario: User updates the Skills in his/her profile
	#Given User is logged into Mars application successfully
	#When User navigate to profile page
	#And User update the Skills 
	#Then the profile skills should be updated successfully 

#Scenario: User updates the education in his/her profile
	#Given User is logged into Mars application successfully
	#When User navigate to profile page
	#And User update the education 
	#Then the profile education should be updated successfully 

#Scenario: User updates the certifications in his/her profile
	#Given User is logged into Mars application successfully
	#When User navigate to profile page
	#And User update the certifications 
	#Then the profile certifications should be updated successfully 