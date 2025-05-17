Feature: Language Switch

  Scenario: User can switch site language to Russian
    Given the user is on the homepage
    When the user switches language to Russian
    Then the Russian version of the site should be displayed
