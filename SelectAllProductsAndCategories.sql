SELECT p.product_name, c.category_name 
FROM products_categories pc
	JOIN products p ON p.product_id = pc.product_id  
	LEFT JOIN categories c ON c.category_id = pc.category_id