# -*- coding: utf-8 -*-
"""
Created on Sun Dec 17 16:53:14 2017

@author: Melike Mat
"""


import networkx as netx
import matplotlib.pyplot as plt


G = netx.MultiGraph()

G.add_edge("Jack", "Olivia", weight=4)
G.add_edge("Jack", "Celine", weight=5)
G.add_edge("Jack", "Winston", weight=9)
G.add_edge("Jack", "Chloe", weight=5)
G.add_edge("Jack", "John", weight=9)
G.add_edge("Olivia", "Celine", weight=8)
G.add_edge("Olivia", "John", weight=7)
G.add_edge("Celine", "Winston", weight=6)
G.add_edge("Winston", "Chloe", weight=11)
G.add_edge("Chloe", "John", weight=7)

pos = netx.spring_layout(G)

netx.draw(G, pos, with_labels = True)
edge_labels = dict([((u, v, ), d['weight']) 
                for u, v, d in G.edges(data=True)])

netx.draw_networkx_edge_labels(G, pos, edge_labels=edge_labels)
netx.draw_networkx_nodes(G, pos, node_size = 3000, node_color = "w")
plt.show()

name_list = ["Jack", "Olivia", "Celine", "Winston", "Chloe", "John"]
name_list2 = ["Jack", "Olivia", "Celine", "Winston", "Chloe", "John"]

for i in name_list2:
    for j in name_list:
        if i != j:
            path = netx.dijkstra_path(G, i, j)
            print("Shortest path from", i, "to", j, end=" = ")
            for k in path:
                print(k, end=" ")
            print()
            
    name_list2.remove(i)
            
source = input("Bir köşe adı girin:")
dfs = netx.dfs_tree(G, source)
pos_d = netx.spring_layout(dfs)
print("Verilen köşeden graphın derinlik öncelikli ağacı")
netx.draw(dfs, pos_d, with_labels = True, node_color=range(6), 
          node_size = 1000, cmap=plt.cm.Blues)
plt.show()


bfs = netx.bfs_tree(G, source)
pos_b = netx.spring_layout(bfs)
print("Verilen köşeden graphın genişlik öncelikli ağacı")
netx.draw(bfs, pos_b, with_labels = True, node_color=range(6), 
          node_size = 1000, cmap=plt.cm.Reds)
plt.show()
