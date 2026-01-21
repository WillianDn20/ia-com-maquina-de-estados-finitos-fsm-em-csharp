Sistema de Inteligência Artificial com Máquina de Estados Finitos (FSM) em C#

Este projeto implementa um sistema de Inteligência Artificial baseado em **Máquina de Estados Finitos (FSM)**
para controle de agentes autônomos, com percepção do ambiente, tomada de decisão e navegação.

O foco está na arquitetura de software, organização do código e lógica de decisão — independente de aspectos visuais.

---

Conceitos Principais

- Máquina de Estados Finitos (FSM)
- Padrão State
- Tomada de decisão baseada em percepção
- Separação de responsabilidades
- Agentes autônomos
- Arquitetura orientada a objetos

---

Estados Implementados

- Idle (ocioso)
- Patrol (patrulha)
- Pursue (perseguição)
- Attack (ataque)
- Runaway (fuga)

Cada estado define:

- Comportamento de entrada (Enter)
- Lógica de execução (Update)
- Comportamento de saída (Exit)

---

Sistema de Percepção

O agente avalia:

- Distância até o jogador
- Ângulo de visão (campo visual)
- Distância de ataque
- Posição relativa (jogador atrás do NPC)

Essas informações determinam as transições entre estados.

---

Ambiente Global

O projeto utiliza um gerenciador de ambiente global (Singleton) para:

- Acessar checkpoints
- Definir local seguro para fuga
- Compartilhar informações entre estados

---

Estrutura dos Scripts

- `State.cs` — classe base da FSM e regras de transição
- `AIController.cs` — controlador principal do agente
- `Idle.cs`, `Patrol.cs`, `Pursue.cs`, `Attack.cs`, `Runaway.cs` — estados especializados
- `GameEnvironment.cs` — contexto global do ambiente

---

Tecnologias e Ferramentas

- C#
- Programação Orientada a Objetos
- Máquina de Estados Finitos (FSM)
- Unity (apenas como ambiente de execução)
- NavMeshAgent (navegação)

---

Objetivo do Projeto

Projeto acadêmico desenvolvido para praticar:

- Modelagem de comportamento com FSM
- Arquitetura de sistemas de IA
- Organização e legibilidade de código
- Lógica de tomada de decisão

> Observação: este repositório contém apenas os scripts principais, com foco em análise técnica e arquitetural.
