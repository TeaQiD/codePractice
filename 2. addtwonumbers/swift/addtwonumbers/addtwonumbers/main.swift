//
//  main.swift
//  addtwonumbers
//
//  Created by Tianqing Feng on 2/4/23.
//

import Foundation

//MARK: - Node Class
class Node<T> {
    var value: T
    var next: Node<T>?
    
    init(value: T, next: Node<T>? = nil){
        self.value = value //value of current node
        self.next = next //reference to next node
    }
}

//MARK: - LinkedList Struct
struct LinkedList<T> {
    var head: Node<T>? //first node
    var tail: Node<T>? //last node
    
    var isEmpty: Bool { head == nil } //is list empty or not
    var count: Int?
    
    init(){}
    
    //push head back with new node
    mutating func push(_ value: T){
        head  = Node(value: value, next: head)
        
        if tail == nil{
            tail = head
        }
    }
    
    //append new node to list(add in the back)
    mutating func append(_ value: T){
        let node = Node(value: value)
        
        if tail != nil {
            tail?.next = node
            tail = node
        }
        else {
            push(value)
        }
    }
    
    //retrive node[index], uses loop
    func node(at index: Int) -> Node<T>? {
        var currentIndex = 0
        var currentNode = head
        
        while currentNode != nil && currentIndex < index{
            currentNode = currentNode?.next
            currentIndex += 1
        }
        
        return currentNode
    }
    
    //insert new node after node[index]
    func insert(_ value: T, after index: Int){
        guard let node = node(at:index) else {return}
        
        node.next = Node(value: value, next: node.next)
    }
    
    //pop node(removing first node)
    mutating func pop() -> T? {
        defer{
            head = head?.next
            
            if isEmpty{
                tail = nil
            }
        }
        
        return head?.value
    }
    
    //remove last node(tail node)
    mutating func removeLast() -> T? {
        guard let head = head else { return nil }
        //guard let head.next != nil else { return pop() } //original, causes case error
        guard (head.next != nil) else { return pop() }
        //        if head.next == nil {
        //            return pop() //using if instead of guard
        //        }
        var previousNode = head
        var currentNode = head
        
        while let next = currentNode.next {
            previousNode = currentNode
            currentNode = next
        }
        
        previousNode.next = nil
        tail = previousNode
        
        return currentNode.value
    }
    
    //get count of linked list
    func getCount() -> Int{
        var currentIndex = 0
        var currentNode = head
        
        while currentNode != nil {
            currentNode = currentNode?.next
            currentIndex += 1
        }
        return currentIndex
    }
}




