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
			int accion=0, regla, reduccion, fila, columna, i =0;
			bool valido = false;
			
			//agregamos el cero a la pila
			pila.Push(0);
			var token = listToken.First;//creo un nodo Token
			listToken.AddLast(new Token());
			do {
				//por cada token de entrada apilara o desapilara...
				//tope de la pila y token de entrada
				//positivo	-> desplazamiento
				//0			-> casilla vacia (error)
				//-1		-> aceptacion
				//<-1		-> reduccion
				
				fila = pila.Peek();
				columna = token.Value.getId()+1;
				
				accion = _tabla[fila, columna];
				
				if(accion > 0) {
					//desplazamiento
					pila.Push(columna);
					pila.Push(accion);
					
					//nos vamos al sig token
					token = token.Next;
				} else if(accion < -1) {
					//ir a la regla
					
					regla = accion*(-1)-1;
					reduccion = _reglas[regla, 1]*2;//pops
					
					for(; 0 < reduccion; reduccion--) {
						pila.Pop();//hacer pop
					}
					
					//agregar al tope de la pila
					fila = pila.Peek();
					columna = _reglas[regla, 0]+1;
					pila.Push(columna);
					pila.Push(_tabla[fila, columna]);
					
				}else  if(accion == -1) {
					valido = true;
					token = token.Next;
				} else {
					//error
					return false;
				}
				i++;
			} while(token != listToken.Last);
			
			return valido;
		}
		
		
		public bool analizar_() {
			Stack<int> pila = new Stack<int>();
			int accion=0, regla, reduccion, fila, columna, i =0;
			String str = "", str2;
			bool valido = false;
			
			//agregamos el cero a la pila
			pila.Push(0);
			var token = listToken.First;//creo un nodo Token
			
			while(i <= listToken.Count) {
				//por cada token de entrada apilara o desapilara...
				//tope de la pila y token de entrada
				//positivo	-> desplazamiento
				//0			-> casilla vacia (error)
				//-1		-> aceptacion
				//< -1		-> reduccion
				
				fila = pila.Peek();
				columna = token.Value.getId()+1;
				
				accion = _tabla[fila, columna];
				str2 = "";
				foreach(int tope in pila) {
					str2 += tope+", ";
				}
				str += "["+fila+", "+columna+"] -> accion "+accion+"\n";
				//System.Windows.Forms.MessageBox.Show(str);
				//System.Windows.Forms.MessageBox.Show(str2);
				if(accion > 0) {
					//desplazamiento
					pila.Push(columna);
					pila.Push(accion);
					
					//nos vamos al sig token
					token = token.Next;
				} else if(accion < -1) {
					//ir a la regla
					
					regla = accion*(-1)-1;
					reduccion = _reglas[regla, 1]*2;//pops
					
					
					System.Windows.Forms.MessageBox.Show("Reduccion: "+reduccion+"Pila: "+ pila.Count);
					for(; 0 < reduccion; reduccion++) {
						pila.Pop();//hacer pop
					}
					
					str2 = "";
					foreach(int tope in pila) {
						str2 += tope+", ";
					}
					str2 += "= "+ i;
					System.Windows.Forms.MessageBox.Show(str2);
					
					//agregar al tope de la pila
					fila = pila.Peek();
					columna = _reglas[regla, 0]+1;
					///str += "fila: "+fila+" columna: "+columna+"] -> accion "+_tabla[fila, columna]+"\n";
					pila.Push(columna);
					pila.Push(_tabla[fila, columna]);
					
				}else  if(accion == -1) {
					valido = true;
				} else {
				System.Windows.Forms.MessageBox.Show(str2);
					//error
					//System.Windows.Forms.MessageBox.Show("error. "+accion);
					return false;
				}
				i++;
			}
	
			return valido;
		}
		
		void matriz() {
			int i = 0;
			String aux;
			
			String[] corte = new string[2];
			while((aux = reglas.ReadLine()) != null) {
				corte = aux.Split('\t');
				_reglas[i,0] = int.Parse(corte[0]);
				_reglas[i++,1] = int.Parse(corte[1]);
			}
			
			i = 0;//reseteo el conteo
			corte = new string[40];
			while((aux = Tabla.ReadLine()) != null) {
				
				corte = aux.Split('\t');
				for(int j = 0; j < 40; j++) {
					_tabla[i,j] = int.Parse(corte[j]);
				}
				i++;
			}
			
		}
		
		public String texto() {
			return ""+_tabla[78,39];
		}
		
		public String getValue(int e) {
			e--;
			if(e == 0) {
				return "var,";
			}else if(e == 1) {
				return "main,";
			}else if(e == 4) {
				return "(,";
			}else if(e == 5) {
				return "),";
			}else if(e == 6) {
				return "{,";
			}else if(e == 7) {
				return "},";
			}else if(e == 18) {
				return "$,";
			}
			return e+",";
		}
		
	}
}
