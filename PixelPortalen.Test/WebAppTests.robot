*** Settings ***
Suite Setup        Open Browser to 'Pixelportalen.com'/localhost Start page    # Suite Setup, this enforces the method how it should start.
Documentation    Tests for pixelportalen    # Info Text
Library    SeleniumLibrary    # Which Library is being used

*** Variables ***
#${Web Link}    http://localhost:5285/

*** Test Cases ***
# {CUSTOMER TESTS}
Scenario/Test1: Customer enters the website And Should See Products On The Homepage
    [Documentation]
    [Tags]    Product Display
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test2: Customer hovers mouse an item, the item displays itself in a "card" format
    [Documentation]
    [Tags]    Product Display
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test3: Customer filters 'age' & 'genre' for specific game and adds it to cart
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test4: Customer removes item from cart
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test5: Customer adds a product and goes to checkout
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

#{ADMIN TESTS}
Scenario/Test1: Admin logs in and see an exclusive admin layout
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test2: Admin adds a new product to the website
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test3: Admin deletes a product from the website
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website

Scenario/Test4: Admin edits an existing product on the website
    [Documentation]
    [Tags]
    Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User enters the website
    
*** Keywords ***
# Suite Setup
Open Browser to 'Pixelportalen.com'/localhost Start page
    Open Browser    http://localhost:5285/    Chrome

# Keyword Scenario 1
User enters the website
    Go To    http://localhost:5285/
