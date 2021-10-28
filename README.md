- Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.
  - Ninguno de los objetos será físico
  ![1 1](https://user-images.githubusercontent.com/58046649/138595469-ee838a55-d62a-413b-b781-0abd087779cf.gif)
  - La esfera tiene físicas, el cubo no
  ![Animation2](https://user-images.githubusercontent.com/58046649/138595587-2ccdc8f9-2c84-45ca-89d1-9ca9e0f86d28.gif)
  - La esfera y el cubo tienen físicas
  ![Animation3](https://user-images.githubusercontent.com/58046649/138595636-66eb5a49-0c31-4520-a7d0-a8f0a41fc423.gif)
  - La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo
  ![imagen](https://user-images.githubusercontent.com/58046649/138595787-ad116cd2-1867-403a-8a03-aee1783850b8.png)
  ![imagen](https://user-images.githubusercontent.com/58046649/138595812-80315107-b3af-484b-993e-96a9f443118d.png)
  - La esfera tiene físicas y el cubo es de tipo IsTrigger y tiene físicas
  ![Animation5](https://user-images.githubusercontent.com/58046649/138595881-dc91c440-64b5-444e-89c3-2595acfff804.gif)
  - La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.
    
    ![imagen](https://user-images.githubusercontent.com/58046649/138602660-3c8001c3-3744-44f1-95d9-4f0b5fd24e7b.png)

- Sobre la escena que has trabajado ubica un cubo que reprente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController. Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección qu estos ejes indican.
  - Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física.
  - Agregar un campo público que permita graduar la velocidad del movimiento desde el inspector de objetos.
  - Estar a la escucha de si el usuario ha utilizado los ejes virtuales. Elegir cuáles se va a permitir utilizar: flechas, awsd
  ![Animation6](https://user-images.githubusercontent.com/58046649/138610835-85965b0c-7524-44c5-961e-ec941bd41bdb.gif)
  
---
3.
- Se deben incluir varios cilindros sobre la escena. Cada vez que el obheto jugador colisione con alguno de ellos, deben aumentar su tamaño y el jugador aumentar puntuación
![3 1](https://user-images.githubusercontent.com/58046649/139345230-f13d6322-84e3-4516-92fe-6cc6af29de2a.gif)

- Agregar cilindros de tipo A, en los que además, si el jugador pulsa la barra espaciadora lo mueve hacia fuera de él
![3 2](https://user-images.githubusercontent.com/58046649/139345584-00d5edf3-2ffe-423d-a0e7-5f0543b12070.gif)

- Se deben incluir cilindros que se alejen del jugador cuando esté próximo.
![3 3](https://user-images.githubusercontent.com/58046649/139345761-675eea65-1272-4aab-9a76-25a88a9314c1.gif)

- Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas: I, L, J, M
![3 4](https://user-images.githubusercontent.com/58046649/139346255-fbdbf7ab-a9ca-4127-971f-0e19f7d851d3.gif)

- Debes ubicar cubos que aumenten de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador
![3 5](https://user-images.githubusercontent.com/58046649/139345985-ed4f5bca-7aaf-4746-ab67-69ff1e1dd57f.gif)
