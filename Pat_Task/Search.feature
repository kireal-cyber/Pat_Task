Feature: Search Functionality

  Scenario: User can search for content
    Given the user opens the homepage for search
    When the user searches for "study programs"
    Then the result "The Women in Tech Project" should be visible
