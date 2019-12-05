Feature: Add To Cart

@mytag
Scenario: Add the products to cart
	Given 'Cooling & Heating' submenu under 'TV & Home Appliances' is presented
	When I select 'Air Conditioner' from menu
	Then I can add 1 item to cart