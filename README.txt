----------- Processo Seletivo TGD -----------

Scripts:

-Player:
	1. Player.cs
		� State Machine do jogador.

	2. PlayerState.cs
		� Classe abstrata para implementar os estados do jogador.

	3. PlayerCreation.cs
		� Classe que implementa o estado de cria��o do jogador.

	4. PlayerIdle.cs
		� Classe que implementa o estado do jogador quando est� parado e no solo.

	5. PlayerWalk.cs
		� Classe que implementa o estado do jogador quando est� andando.

	6. PlayerJump.cs
		� Classe que implementa o estado do jogador quando est� pulando.

	7. PlayerFall.cs
		� Classe que implementa o estado do jogador quando est� caindo no ar.

	8. PlayerInput.cs
		� Script para receber inputs do jogador.



-Serras:
	1. Saw.cs
		� State Machine da serra.

	2. SawState.cs
		� Classe abstrata para implementar os estados da serra.

	3. SawMove.cs
		� Classe que implementa o estado de movimenta��o da serra.
	


-Frutas:
	1. Fruit.cs
		� State Machine da fruta.

	2. FruitState.cs
		� Classe abstrata para implementar os estados da fruta.

	3. FruitIdle.cs
		� Classe que implementa o estado da fruta antes de ser coletada pelo jogador (parada).

	4. FruitDisappear.cs
		� Classe que implementa o estado da fruta depois de ser coletada pelo jogador (desaparecendo depois de ser coletada).



-Terrain:
	1. ThinPlatform.cs
		� Classe para conrolas as plataformas finas (one way platforms).



-Game:
	1. Game.cs
		� Classe para controlar os eventos do jogo (como restart e vit�ria).

	2. ComandKeysSprite.cs
		� Script apenas para controlar o sprite que aparece no come�o do jogo mostrado as teclas direcionais para informar ao jogador quais s�o as teclas necess�rias para jogar.

	3. QuitButton.cs
		� Script para controlar o bot�o de sa�da do jogo (canto superior direito).

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Anima��es:

-Player:
	1. PlayerCreation.anim
		� Anima��o do jogador quando est� sendo formado.
		� Acontece quando inicia o jogo, quando o jogador morre ou quando ganha o jogo.
		� Obs: Essa anima��o n�o existia no Asset Pixel Adventure, ela foi criada invertendo a anima��o de coleta das frutas e adicionando mais alguns frames.
	
	2. PlayerIdle.anim
		� Anima��o do jogador parado.

	3. PlayerWalk.anim
		� Anima��o do jogador andando.

	4. PlayerJump.anim
		� Anima��o do jogador pulando.

	5. PlayerFall.anim
		� Anima��o do jogador caindo.



-Serra:	
	1. SawSpin.anim
		� Anima��o da serra girando.



-Frutas:
	1. OrangeIdle.anim
		� Anima��o da fruta laranja parada (antes de ser coletada pelo jogador).	
	
	2. AppleIdle.anim
		� Anima��o da fruta ma�� parada (antes de ser coletada pelo jogador).	

	3. FruitDisappear.anim
		� Anima��o da fruta desaparecendo (depois de ser coletada pelo jogador).
	
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------