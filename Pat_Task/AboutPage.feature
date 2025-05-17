Feature: About Page

  Scenario: User can see the About page header
    Given the user is on the EHU homepage
    When the user clicks on the "About" link
    Then the About page header should be visible
