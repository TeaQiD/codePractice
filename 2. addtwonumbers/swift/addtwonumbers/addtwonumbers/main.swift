//
//  main.swift
//  addtwonumbers
//
//  Created by Tianqing Feng on 2/4/23.
//

import Foundation


class Node<T> {
    var value: T
    var next: Node<T>?
    
    init(value: T, next: Node<T>? = nil){
        self.value = value
        self.next = next
    }
}




