Nome do projeto:
 prototipo-personagem-coleta
Aluno: 
 Bruno Carvalho 
Turma:
 2026.29.09
Feito com:
 Unity 6 
 C#
Sobre o projeto:
 Temos um personagem amarelo que está em uma parte de um viaduto
 durante a noite, o objetivo dele é coletar as latinhas que estão
 presentes neste mesmo viaduto.
O que o projeto faz: 
 o jogador movimenta o personagem com as setas/WASD 
 e consegue pular com espaço
 ao encostar nas latinhas o personagem consome elas  
 O que o projeto contém 
Cenas:
 Rua: um viaduto durante a noite
Scripts: 
  movimento:
  define teclas de movimento e salto, junto a isso define velocidade de caminhada e salto
  rotator:
  faz objetos coletáveis ficarem rodando 
  coletavel:
  quando identifica colisão deleta o coletavel(vai no jogador)
  camera:
  faz a câmera acompanhar o jogador
 Objetos principais:
 jogador
 Personagem(dentro de jogador)

 plane(colisor do chão)
 
 Rua
 Conjunto de blocos e cores para o cenário(dentro de Rua)

 BloxyCola(coletavel)

 Spot light(luz para o cenário)

 câmera(literalmente uma câmera que segue o jogador)
 
Recursos usados:
   Rigidbody
   Collider com Is Trigger
   mesh collider
   capsule collider
   box collider
   character controler
   camera
   light

 Controles 
Setinhas/WASD:
movimentam o personagem nas 4 direções
leste,oeste,norte,sul

espaço:
faz o personagem pular
O que eu aprendi 
 Muita coisa, mas se for para resumir eu diria que C# orientado a objeto
 básico, mais lógica de programação, modelação básica no Blender, usar
 texturas na Unity e usar o Github um pouco melhor
## Como abrir
Baixe o projeto, abra o Unity Hub, clique em **Add** e escolha a pasta do projeto.
