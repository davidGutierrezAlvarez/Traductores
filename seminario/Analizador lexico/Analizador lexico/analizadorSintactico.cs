/*
 * Creado por SharpDevelop.
 * Usuario: david
 * Fecha: 15/02/2020
 * Hora: 08:26 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Analizador_lexico {

	public class analizadorSintactico {
		LinkedList<Token> listToken;//lista de tokens de entrada
		StreamReader reglas = new StreamReader(@"file\\GR2slrRulesId.txt");
		StreamReader Tabla  = new StreamReader(@"file\\GR2slrTable.txt");
		int[,] _reglas = new int[44, 2];
		int[,] _tabla  = new int[84,40];
		
		
		public analizadorSintactico(LinkedList<Token> tokens) {
			//recive una lista de tokens
			listToken = new LinkedList<Token>(tokens);
			matriz();//genera las matrices (son 2)
			
		}
		
		public bool analizar() {
			Stack<int> pila = new Stack<int>();
			//agregamos el cero a la pila
			pila.Push(0);
			int accion=0, regla, reduccion;
			bool positivo =true;
			
			var token = listToken.First;//creo un nodo Token

			do {
				//por cada token de entrada apilara o desapilara...
				//tope de la pila y token de entrada
				//positivo	-> desplazamiento
				//0			-> casilla vacia
				//-1		-> aceptacion
				//< -1		-> reduccion
				if(positivo)
					accion = _tabla[pila.Peek(), token.Value.getId()+1];
				
				
				System.Windows.Forms.MessageBox.Show("["+pila.Peek()+", "+(token.Value.getId()+1)+"] -> accion "+accion);
				if(accion > 0) {
					//desplazamiento
					pila.Push(accion);
					//nos vamos al sig token
					token = token.Next;
					//System.Windows.Forms.MessageBox.Show("push. "+accion+"\ntoken "+token.Value.getId()+1);
					positivo = true;
				} else if(accion < -1) {
					//ir a la regla
					reduccion = accion*(-1)-1;
					regla = (_reglas[reduccion, 1]);//pops
					
					for(int j = 0; j < regla; j++) {
						pila.Pop();//hacer pop
					}
					
					//ir a...
					accion = _tabla[pila.Peek(), _reglas[reduccion, 0]+1];
					
					System.Windows.Forms.MessageBox.Show("pop\n["+pila.Peek()+ ", " + (_reglas[reduccion, 0]+1)+"] -> "+ accion);
					
					//agregar al tope de la pila
					pila.Push(_reglas[reduccion, 0]);		
					
					positivo = false;
					
					
				}else  if(accion == 1) {
					return true;
				} else {
					//error
					System.Windows.Forms.MessageBox.Show("error. "+accion);
					return false;
				}
			} while(token != listToken.Last);
			
			return true;
		}
		
		void matriz() {
			int i = 0;
			String aux;
			
			String[] corte = new string[2];
			while((aux = reglas.ReadLine()) != null) {
				corte = aux.Split('\t');
				_reglas[i,0] = Int32.Parse(corte[0]);
				_reglas[i++,1] = Int32.Parse(corte[1]);
			}
			
			i = 0;//reseteo el conteo
			corte = new string[40];
			while((aux = Tabla.ReadLine()) != null) {
				
				corte = aux.Split('\t');
				for(int j = 0; j < 40; j++) {
					_tabla[i,j] = Int32.Parse(corte[j]);
				}
				i++;
			}
			
		}
		
		public String texto() {
			return ""+_tabla[78,39];
		}
		
		
	}
}
