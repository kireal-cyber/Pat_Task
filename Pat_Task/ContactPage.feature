Feature: Contact Page

  Scenario: User can see all contact details
    Given the user is on the Contact page
    Then the email address should be visible
    And the Lithuanian phone number should be visible
    And the Belarusian phone number should be visible
    And the Facebook link should be visible
    And the Telegram link should be visible
    And the VK link should be visible
