----------- Processo Seletivo TGD -----------

Scripts:

-Player:
	1. Player.cs
		• State Machine do jogador.

	2. PlayerState.cs
		• Classe abstrata para implementar os estados do jogador.

	3. PlayerCreation.cs
		• Classe que implementa o estado de criação do jogador.

	4. PlayerIdle.cs
		• Classe que implementa o estado do jogador quando está parado e no solo.

	5. PlayerWalk.cs
		• Classe que implementa o estado do jogador quando está andando.

	6. PlayerJump.cs
		• Classe que implementa o estado do jogador quando está pulando.

	7. PlayerFall.cs
		• Classe que implementa o estado do jogador quando está caindo no ar.

	8. PlayerInput.cs
		• Script para receber inputs do jogador.



-Serras:
	1. Saw.cs
		• State Machine da serra.

	2. SawState.cs
		• Classe abstrata para implementar os estados da serra.

	3. SawMove.cs
		• Classe que implementa o estado de movimentação da serra.
	


-Frutas:
	1. Fruit.cs
		• State Machine da fruta.

	2. FruitState.cs
		• Classe abstrata para implementar os estados da fruta.

	3. FruitIdle.cs
		• Classe que implementa o estado da fruta antes de ser coletada pelo jogador (parada).

	4. FruitDisappear.cs
		• Classe que implementa o estado da fruta depois de ser coletada pelo jogador (desaparecendo depois de ser coletada).



-Terrain:
	1. ThinPlatform.cs
		• Classe para conrolas as plataformas finas (one way platforms).



-Game:
	1. Game.cs
		• Classe para controlar os eventos do jogo (como restart e vitória).

	2. ComandKeysSprite.cs
		• Script apenas para controlar o sprite que aparece no começo do jogo mostrado as teclas direcionais para informar ao jogador quais são as teclas necessárias para jogar.

	3. QuitButton.cs
		• Script para controlar o botão de saída do jogo (canto superior direito).

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Animações:

-Player:
	1. PlayerCreation.anim
		• Animação do jogador quando está sendo formado.
		• Acontece quando inicia o jogo, quando o jogador morre ou quando ganha o jogo.
		• Obs: Essa animação não existia no Asset Pixel Adventure, ela foi criada invertendo a animação de coleta das frutas e adicionando mais alguns frames.
	
	2. PlayerIdle.anim
		• Animação do jogador parado.

	3. PlayerWalk.anim
		• Animação do jogador andando.

	4. PlayerJump.anim
		• Animação do jogador pulando.

	5. PlayerFall.anim
		• Animação do jogador caindo.



-Serra:	
	1. SawSpin.anim
		• Animação da serra girando.



-Frutas:
	1. OrangeIdle.anim
		• Animação da fruta laranja parada (antes de ser coletada pelo jogador).	
	
	2. AppleIdle.anim
		• Animação da fruta maçã parada (antes de ser coletada pelo jogador).	

	3. FruitDisappear.anim
		• Animação da fruta desaparecendo (depois de ser coletada pelo jogador).
	
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------