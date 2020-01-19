﻿@Browser:Chrome
@Browser:Firefox
Feature: XUnitDemoFeatureTests
	In order to verify the SpecFlow variants plugin for features
	As a developer
	I want to be able to run integration tests to validate the plugin

Background:
	Given I am on the Google home page

Scenario: A single test without examples or tags
	When I search for 'totaltest github'
	Then the following result should be listed:
	"""
	TotalTest (Prab) · GitHub
	"""

@Settings
@Tools
Scenario: A test with non-variant tags
	When I search for 'totaltest github'
	Then there should be links to the tags specified

Scenario Outline: A test with variant tags and examples
	And I navigate to the 'TotalTest' Github page
	When I drill into the '<Repo>' repository
	Then I should be on the website '<Site>'
	Examples:
	| Repo                | Site                                             |
	| totaltest.github.io | https://github.com/TotalTest/totaltest.github.io |
	| SpecFlow.Variants   | https://github.com/TotalTest/SpecFlow.Variants   |