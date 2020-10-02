# PublicaTecnologia

Para roda a aplicação é necessario ter instalado a versão 2019 do Visual Studio.
https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Community&rel=16
Pode ser a versão community.

Após a instalação, abra o Visual Studio e vá na aba Extensões e instale a Extensão "GitHub Extension for Visual Studio" - Recomendo.
Após isso reinicie o Visual Studio e agora já é possivel clonar o repositório na sua máquina de maneira fácil.

Abra o projeto e cliquei com o botão direito na solução do projeto e vá em "Gerenciar Pacotes NuGet para a solução".
Procure pelo "EntityFramework por Microsoft v6.2.0", instale e reinicie o Visual Studio.
Vá na aba Exibir -> Outras Janela -> "Console do Gerenciador de Pacotes" e digite os seguintes códigos:

Add-Migration,
Vai pedir para colocar um nome: Segundo...
Aguarde.

Update-DataBase...
Aguarde.

Após realizar essas etapas é só clicar em Iniciar (F5).
Ai é só adicionar a jogadora Maria no botão Adicionar Jogadora.
Depois adicionar as partidas no botão Adicionar Partida.
E para visualizar as partidas é só clicar no Botão Visualizar Partidas.

Fiz o programa para poder adicionar mais jogadoras e ainda temos na tela de visualizar partidas um filtro para escolher somente uma jogadora.

Para futuras atualizações gostaria de colocar a idade e a jogadora que teve a maior quantidade de pontos.
