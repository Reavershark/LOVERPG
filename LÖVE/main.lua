Camera = require "camera"

--Valid gameStates: "Main menu", "Loadout"
gameState = "Main menu"
mainMenuIndex = 0

function love.load()

	--Window setup
	love.window.setMode(800, 600, {resizable=true, minwidth=800, minheight=600})
	icon = love.image.newImageData("sprites/windowIcon.png")
	love.window.setIcon(icon)
	love.window.setTitle("Dank game")
	
	--Camera setup
	cam = Camera.new()
	cam:lockPosition(love.graphics.getWidth()/2, love.graphics.getHeight()/2)

end

function love.draw()
	if gameState=="Main menu" then
	
		cam:attach()
		
		--Draw Title
		love.graphics.setFont(love.graphics.newFont("fonts/PressStart2P.ttf", 48))
		love.graphics.print("Dank game", 200, 150)
		
		--Draw state select and arrow
		love.graphics.setFont(love.graphics.newFont("fonts/PressStart2P.ttf", 32))
		if mainMenuIndex == 0 then --Start
			love.graphics.print("-> Start\n   Loadout\n   Settings\n   Exit", 200, 250)
		end
		if mainMenuIndex == 1 then --Loadout
			love.graphics.print("   Start\n-> Loadout\n   Settings\n   Exit", 200, 250)
		end
		if mainMenuIndex == 2 then --Settings
			love.graphics.print("   Start\n   Loadout\n-> Settings\n   Exit", 200, 250)
		end
		if mainMenuIndex == 3 then --Exit
			love.graphics.print("   Start\n   Loadout\n   Settings\n-> Exit", 200, 250)
		end
		
		cam:detach()
	end
end

--Add variables for every key name

function love.keypressed(key, scancode, isrepeat)
	if gameState=="Main menu" then
	
		--Selection movement
		if key=="down" then
			mainMenuIndex = mainMenuIndex + 1
		end
		if key=="up" then
			mainMenuIndex = mainMenuIndex - 1
		end
		if mainMenuIndex < 0 then
			mainMenuIndex = 3
		end
		if mainMenuIndex > 3 then
			mainMenuIndex = 0
		end
		
		--Selection confirm
		if key=="return" then
			if mainMenuIndex == 0 then --Start
				
			end
			if mainMenuIndex == 1 then --Loadout
				gameState = "Loadout"
			end
			if mainMenuIndex == 2 then --Settings
				
			end
			if mainMenuIndex == 3 then --Exit
				love.event.quit()
			end

		end
	end
end