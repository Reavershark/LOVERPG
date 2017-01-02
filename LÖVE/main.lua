Camera = require "camera"

function love.load()
	--Window setup
	love.window.setMode(800, 600, {resizable=true, minwidth=800, minheight=600})
	icon = love.image.newImageData("sprites/windowIcon.png")
	love.window.setIcon(icon)
	love.window.setTitle("Dank game")
	
	--Camera setup
	cam = Camera.new()
	cam:lockPosition(love.graphics.getWidth()/2, love.graphics.getHeight()/2)

	--Load font in RAM
	font = love.graphics.newFont("fonts/PressStart2P.ttf")
	love.graphics.setFont(font)
end

function love.draw()
	cam:attach()
	--Test draw
	love.graphics.print("Hello world!\nYour display calls itself '" .. love.window.getDisplayName(1) .. "'\nSooooo...\nYea.", 0, 10)
	cam:detach()
end