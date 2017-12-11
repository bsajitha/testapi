Feature: Search API
	In order to search
	As an API Consumer
	I want the API to return appropriate http response codes

Scenario: Valid search request
	Given I search for user id 2
	When the response is received
	Then I will receive an OK response